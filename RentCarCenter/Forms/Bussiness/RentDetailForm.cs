using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCarCenter.Services;
using RentCarCenter.Models;
using RentCarCenter.Models.Base;

namespace RentCarCenter.Forms.Bussiness
{
    public partial class RentDetailForm : Form
    {
        private GenericRepository<RentDetail> _rentDetail;
        private GenericRepository<Customer> _customer;
        private GenericRepository<Vehicle> _vehicle;
        private GenericRepository<Employee> _employee;
        private bool _editionMode;
        private RentDetail _entityToEdit;
        private int _gridViewLastSelectedRowIndex = 0;

        public RentDetailForm()
        {
            InitializeComponent();
            _rentDetail = new GenericRepository<RentDetail>();
            _customer = new GenericRepository<Customer>();
            _vehicle = new GenericRepository<Vehicle>();
            _employee = new GenericRepository<Employee>();
        }

        private async Task RefreshGridView()
        {
            var data = await _rentDetail.GetAll(nameof(Vehicle), nameof(Customer), nameof(Employee));

            rentDataGrid.DataSource = data.Select(d => new {
                d.Id,
                Employee = d.Employee.Name,
                Vehicle = d.Vehicle.Description,
                NoLicensePlate = d.Vehicle.NoLicensePlate,
                Customer = d.Customer.Name,
                d.RentDate,
                d.PriceByDay,
                d.RentDays,
                d.Comment,
                d.HasBeenReturned,
                d.Status
            }).ToList();
        }

        private void CleanForm()
        {
            commentTxt.Clear();
            cbStatus.SelectedIndex = 0;
            nPriceByDay.Value = 0;
            nRentDays.Value = 0;
            dpRentDate.Value = DateTime.Today;
            if (cbCustomer.Items.Count > 0)
                cbCustomer.SelectedIndex = 0;
            if (cbEmployee.Items.Count > 0)
                cbEmployee.SelectedIndex = 0;
            if (cbVehicle.Items.Count > 0)
                cbVehicle.SelectedIndex = 0;
            if (cbStatus.Items.Count > 0)
                cbStatus.SelectedIndex = 0;
        }

        private async Task RefreshComboBoxes()
        {
            cbCustomer.DataSource = (await _customer.GetAll()).Where(c => c.Status == StatusEnum.Activado).ToList();
            cbCustomer.ValueMember = nameof(Customer.Id);
            cbCustomer.DisplayMember = nameof(Customer.Name);

            cbVehicle.DataSource = (await _vehicle.GetAll()).Where(v => v.IsAvailable).ToList();
            cbVehicle.ValueMember = nameof(Vehicle.Id);
            cbVehicle.DisplayMember = nameof(Vehicle.Description);

            cbEmployee.DataSource = (await _employee.GetAll()).Where(e => e.Status == StatusEnum.Activado).ToList();
            cbEmployee.ValueMember = nameof(Employee.Id);
            cbEmployee.DisplayMember = nameof(Employee.Name);

            cbStatus.DataSource = Enum.GetValues(typeof(StatusEnum));

        }

        private async Task SaveEntity(bool exists)
        {
            if (!exists) {
                var rentDetail = new RentDetail()
                {
                    RentDate = dpRentDate.Value,
                    PriceByDay = (double)nPriceByDay.Value,
                    RentDays = (int)nRentDays.Value,
                    Status = (StatusEnum)cbStatus.SelectedItem,
                    Comment = commentTxt.Text.Trim(),
                    EmployeeId = int.TryParse(cbEmployee.SelectedValue.ToString(), out int idEmployee) ? idEmployee : 0,
                    VehicleId = int.TryParse(cbVehicle.SelectedValue.ToString(), out int idVehicle) ? idVehicle : 0,
                    CustomerId = int.TryParse(cbCustomer.SelectedValue.ToString(), out int idCustomer) ? idCustomer : 0
                };
                await _rentDetail.Add(rentDetail);
                if (rentDetail.Status == StatusEnum.Activado)
                {
                    var vehicle = await _vehicle.Get(rentDetail.VehicleId);
                    vehicle.IsAvailable = false;
                    _vehicle.Update(vehicle);
                    await _vehicle.SaveAsync();
                }
            } else {
                _entityToEdit.RentDate = dpRentDate.Value;
                _entityToEdit.PriceByDay = (double)nPriceByDay.Value;
                _entityToEdit.RentDays = (int)nRentDays.Value;
                _entityToEdit.Status = (StatusEnum)cbStatus.SelectedItem;
                _entityToEdit.Comment = commentTxt.Text;
                _entityToEdit.EmployeeId = int.TryParse(cbEmployee.SelectedValue.ToString(), out int idEmployee) ? idEmployee : 0;
                _entityToEdit.VehicleId = int.TryParse(cbVehicle.SelectedValue.ToString(), out int idVehicle) ? idVehicle : 0;
                _entityToEdit.CustomerId = int.TryParse(cbCustomer.SelectedValue.ToString(), out int idCustomer) ? idCustomer : 0;
                _rentDetail.Update(_entityToEdit);
                if (_entityToEdit.Status == StatusEnum.Eliminado)
                {
                    var vehicle = await _vehicle.Get(_entityToEdit.VehicleId);
                    vehicle.IsAvailable = true;
                    _vehicle.Update(vehicle);
                    await _vehicle.SaveAsync();
                }
            }
            await _rentDetail.SaveAsync();
        }

        private int GetIdCurrentRow()
        {
            return int.TryParse(rentDataGrid.CurrentRow.Cells[nameof(RentDetail.Id)].Value.ToString(), out int id) ? id : 0;
        }

        private async Task EditionModeToggle()
        {
            if (_editionMode)
            {
                EditBtn.Text = "Editar";
                CleanForm();
            }
            else
            {
                _entityToEdit = await _rentDetail.Get(GetIdCurrentRow());
                EditBtn.Text = "Cancelar";

                commentTxt.Text = _entityToEdit.Comment;
                nPriceByDay.Value = (decimal)_entityToEdit.PriceByDay;
                nRentDays.Value = _entityToEdit.RentDays;
                dpRentDate.Value = _entityToEdit.RentDate;
                cbEmployee.SelectedValue = _entityToEdit.EmployeeId;
                cbCustomer.SelectedValue = _entityToEdit.CustomerId;
                cbVehicle.SelectedValue = _entityToEdit.VehicleId;
                cbStatus.SelectedItem = _entityToEdit.Status;

            }

            DeleteBtn.Enabled = !DeleteBtn.Enabled;
            rentDataGrid.Enabled = !rentDataGrid.Enabled;

            _editionMode = !_editionMode;
        }

        private async void RentDetailService_Load(object sender, EventArgs e)
        {
            await RefreshGridView();
            await RefreshComboBoxes(); 
            dpRentDate.MinDate = DateTime.Today;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_editionMode)
            {
                string msj = $"Esta seguro que quiere editar el registro #{_entityToEdit.Id}? Esta acción no se podra deshacer.";
                DialogResult dialogResult = MessageBox.Show(msj, "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult != DialogResult.Yes) 
                    return;

                await SaveEntity(true);
                await EditionModeToggle();
            }
            else
            {
                await SaveEntity(false);
                _gridViewLastSelectedRowIndex = rentDataGrid.Rows.Count - 1;
            }

            rentDataGrid.FirstDisplayedScrollingRowIndex = _gridViewLastSelectedRowIndex;

            await RefreshGridView();
            await RefreshComboBoxes();
            CleanForm();
        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            if (rentDataGrid == null) return;

            await EditionModeToggle();
        }

        private void rentDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            _gridViewLastSelectedRowIndex = rentDataGrid.CurrentRow.Index;
        }

        private async Task DeleteEntity(int Id)
        {
            await _rentDetail.Delete(Id);

            var rentDetail = await _rentDetail.Get(Id,nameof(Vehicle));
            var vehicle = await _vehicle.Get(rentDetail.VehicleId);
            vehicle.IsAvailable = true;
            _vehicle.Update(vehicle);
            await _vehicle.SaveAsync();

            await _rentDetail.SaveAsync();
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (rentDataGrid.CurrentRow == null) return;

            var id = GetIdCurrentRow();

            DialogResult dialogResult = MessageBox.Show($"Esta seguro que quiere eliminar el registro #{id}?", "Eliminar",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                await DeleteEntity(id);
                await RefreshGridView();
            }

            rentDataGrid.FirstDisplayedScrollingRowIndex = _gridViewLastSelectedRowIndex;
        }
    }
}
