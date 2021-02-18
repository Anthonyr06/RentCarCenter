using RentCarCenter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCarCenter.Utilities;
using RentCarCenter.Data;
using TRC.Bussiness.Repository;
using RentCarCenter.Models.Base;

namespace RentCarCenter.Forms.Maintenance
{
    public partial class VehicleForm : Form
    {
        private GenericRepository<Vehicle> _Vehicle;
        private GenericRepository<FuelType> _FuelType;
        private GenericRepository<VehicleModel> _VehicleModel;
        private Vehicle _entityToEdit;
        private bool _editionMode;
        private int _gridViewLastSelectedRowIndex = 0;

        public VehicleForm()
        {
            _Vehicle = new GenericRepository<Vehicle>();
            _VehicleModel = new GenericRepository<VehicleModel>();
            _FuelType = new GenericRepository<FuelType>();
            InitializeComponent();
        }

        private async void VehicleCRUD_Load(object sender, EventArgs e)
        {
           await RefreshGridView();
           await RefreshComboBoxes();
           CleanForm();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            _gridViewLastSelectedRowIndex = dataGridView1.CurrentRow.Index;
        }

        private async Task RefreshGridView()
        {
            var data = await _Vehicle.GetAll(nameof(VehicleModel),nameof(FuelType));

            dataGridView1.DataSource = data.Select( d => new {
                d.Id,
                d.Description,
                d.NoChassis,
                d.NoMotor,
                d.NoLicensePlate,
                FuelType = d.FuelType.Description,
                VehicleModel = d.VehicleModel.Description,
                d.Status
            }).ToList();
        }

        private async Task RefreshComboBoxes()
        {
            cbFuel.DataSource = await _FuelType.GetAll();
            cbFuel.ValueMember = nameof(FuelType.Id);
            cbFuel.DisplayMember = nameof(FuelType.Description);

            cbModel.DataSource = await _VehicleModel.GetAll();
            cbModel.ValueMember = nameof(VehicleModel.Id);
            cbModel.DisplayMember = nameof(VehicleModel.Description);

            cbStatus.DataSource = Enum.GetValues(typeof(StatusEnum));

        }

        private void CleanForm()
        {
            ActionControl.ClearTextBoxes(txtDescription);
            ActionControl.ClearTextBoxes(txtChassis);
            ActionControl.ClearTextBoxes(txtLicense);
            ActionControl.ClearTextBoxes(txtMotor);
            cbStatus.SelectedIndex = 0;

            if (cbModel.Items.Count > 0)
                cbModel.SelectedIndex = 0;
            if (cbFuel.Items.Count > 0)
                cbFuel.SelectedIndex = 0;
        }

        private async Task SaveEntity()
        {
            var Vehicle = new Vehicle()
            {
                Description = txtDescription.Text.Trim(),
                NoChassis = txtChassis.Text.Trim(),
                NoLicensePlate = txtLicense.Text.Trim(),
                NoMotor = txtMotor.Text.Trim(),
                Status = (StatusEnum)cbStatus.SelectedItem,
                VehicleModelId = int.TryParse(cbModel.SelectedValue.ToString(), out int idVehicleModel) ? idVehicleModel : 0,
                FuelTypeId = int.TryParse(cbFuel.SelectedValue.ToString(), out int idFuelType) ? idFuelType : 0
            };
            await _Vehicle.Add(Vehicle);
            await _Vehicle.SaveAsync();
        }
        private async Task UpdateEntity()
        {
            _entityToEdit.Description = txtDescription.Text.Trim();
            _entityToEdit.NoChassis = txtChassis.Text;
            _entityToEdit.NoLicensePlate = txtLicense.Text;
            _entityToEdit.NoMotor = txtMotor.Text;
            _entityToEdit.Status = (StatusEnum)cbStatus.SelectedItem;
            _entityToEdit.VehicleModelId = int.TryParse(cbModel.SelectedValue.ToString(), out int idVehicleModel) ? idVehicleModel : 0;
            _entityToEdit.FuelTypeId = int.TryParse(cbFuel.SelectedValue.ToString(), out int idFuelType) ? idFuelType : 0;

            _Vehicle.Update(_entityToEdit);
            await _Vehicle.SaveAsync();
        }

        private bool IsFormValid()
        {
            return txtDescription.Text.Trim().Length > 0 && txtDescription.Text.Trim().Length <= 200
                && txtChassis.Text.Trim().Length > 0 && txtChassis.Text.Trim().Length <= 20
                && txtLicense.Text.Trim().Length > 0 && txtLicense.Text.Trim().Length <= 20
                && txtMotor.Text.Trim().Length > 0 && txtMotor.Text.Trim().Length <= 20;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsFormValid())
            {
                string msj = "Todos los campos son obligatorios.";
                MessageBox.Show(msj, "Revise los datos!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_editionMode)
            {
                string msj = $"Esta seguro que quiere editar el registro #{_entityToEdit.Id}? Esta acción no se podra deshacer.";
                DialogResult dialogResult = MessageBox.Show(msj, "Modificar",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    await UpdateEntity();
                    await EditionModeToggle();
                    await RefreshGridView();
                }
                else
                    return;
            }
            else
            {
                await SaveEntity();
                await RefreshGridView();
                _gridViewLastSelectedRowIndex = dataGridView1.Rows.Count - 1;
            }

            dataGridView1.FirstDisplayedScrollingRowIndex = _gridViewLastSelectedRowIndex;

            CleanForm();

        }

        private async Task DeleteEntity(int Id)
        {
            await _Vehicle.Delete(Id);
            await _Vehicle.SaveAsync();
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var id = GetIdCurrentRow();

            DialogResult dialogResult = MessageBox.Show($"Esta seguro que quiere eliminar el registro #{id}?", "Eliminar",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                await DeleteEntity(id);
                await RefreshGridView();
            }

            dataGridView1.FirstDisplayedScrollingRowIndex = _gridViewLastSelectedRowIndex;

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
                EditBtn.Text = "Cancelar modificacion";

                _entityToEdit = await _Vehicle.Get(GetIdCurrentRow());
                txtDescription.Text = _entityToEdit.Description;
                txtChassis.Text = _entityToEdit.NoChassis;
                txtLicense.Text = _entityToEdit.NoLicensePlate;
                txtMotor.Text = _entityToEdit.NoMotor;
                cbFuel.SelectedValue = _entityToEdit.FuelTypeId;
                cbModel.SelectedValue = _entityToEdit.VehicleModelId;
                cbStatus.SelectedItem = _entityToEdit.Status;
                
            }

            DeleteBtn.Enabled = !DeleteBtn.Enabled;
            dataGridView1.Enabled = !dataGridView1.Enabled;
            
            _editionMode = !_editionMode;
        }

        private int GetIdCurrentRow()
        {
            return int.TryParse(dataGridView1.CurrentRow.Cells[nameof(Vehicle.Id)].Value.ToString(), out int id) ? id : 0;
        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            await EditionModeToggle();
        }

    }
}
