using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCarCenter.Models;
using RentCarCenter.Models.Base;
using RentCarCenter.Services;

namespace RentCarCenter.Forms.Bussiness
{
    public partial class InspectionForm : Form
    {
        private GenericRepository<Inspection> _inspection;
        private GenericRepository<RentDetail> _rentDetail;
        private bool _editionMode;
        private Inspection _entityToEdit;
        private int _gridViewLastSelectedRowIndex = 0;
       // private int _rentDataGridLastSelectedRowIndex = 0;

        public InspectionForm()
        {
            InitializeComponent();
            _rentDetail = new GenericRepository<RentDetail>();
            _inspection = new GenericRepository<Inspection>();
        }

        private async void InspectionService_Load(object sender, EventArgs e)
        {
            await RefreshGridView();
            cbStatus.DataSource = Enum.GetValues(typeof(StatusEnum));
        }

        public async Task RefreshGridView()
        {
            var data = await _inspection.GetAll(nameof(RentDetail));

            inspectionDataGrid.DataSource = data.Select(d => new {
                d.Id,
                RentComment = d.RentDetail.Comment,
                d.IsGrated,
                d.FuelQuantity,
                d.HasHydraulicCat,
                d.HasSpareTire,
                d.HasBrokenMirror,
                d.Date,
                d.Status
            }).ToList();

            var rentData = await _rentDetail.GetAll(nameof(Vehicle), nameof(Customer), nameof(Employee));

            rentDataGrid.DataSource = rentData.Select(d => new {
                d.Id,
                Vehicle = d.Vehicle.Description,
                Customer = d.Customer.Name,
                d.RentDate,
                d.PriceByDay,
                d.Comment,
                Returned = d.HasBeenReturned,
                d.Status
            }).Where(r => r.Returned).ToList();
        }

        private void CleanForm()
        {
            if (cbFuelQuantity.Items.Count > 0)
                cbFuelQuantity.SelectedIndex = 0;
            cbHasBrokenMirror.Checked = false;
            cbHasHydraulicCat.Checked = false;
            cbHasSpareTire.Checked = false;
            cbIsGrated.Checked = false;
            cbStatus.SelectedIndex = 0;
            dpDate.Value = DateTime.Today;
        }

        private int GetIdCurrentRow()
        {
            return int.TryParse(inspectionDataGrid.CurrentRow.Cells[nameof(ReturnDetail.Id)].Value.ToString(), out int id) ? id : 0;
        }

        private async Task DeleteEntity(int Id)
        {
            await _inspection.Delete(Id);
            await _inspection.SaveAsync();
        }

        private async Task SaveEntity(bool exists)
        {
            if (!exists)
            {
                var inspection = new Inspection()
                {
                    Date = dpDate.Value,
                    FuelQuantity = cbFuelQuantity.SelectedItem.ToString(),
                    IsGrated = cbIsGrated.Checked,
                    HasBrokenMirror = cbHasBrokenMirror.Checked,
                    HasHydraulicCat = cbHasHydraulicCat.Checked,
                    HasSpareTire = cbHasSpareTire.Checked,
                    Status = (StatusEnum)cbStatus.SelectedItem,
                    RentDetailId = int.TryParse(rentDataGrid.CurrentRow.Cells[nameof(RentDetail.Id)].Value.ToString(), out int rentDetailId) ? rentDetailId : 0
                };
                await _inspection.Add(inspection);
            }
            else
            {
                _entityToEdit.FuelQuantity = cbFuelQuantity.SelectedItem.ToString();
                _entityToEdit.IsGrated = cbIsGrated.Checked;
                _entityToEdit.HasBrokenMirror = cbHasBrokenMirror.Checked;
                _entityToEdit.HasHydraulicCat = cbHasHydraulicCat.Checked;
                _entityToEdit.HasSpareTire = cbHasSpareTire.Checked;
                _entityToEdit.Date = dpDate.Value;
                _entityToEdit.Status = (StatusEnum)cbStatus.SelectedItem;
                _inspection.Update(_entityToEdit);
            }
            await _inspection.SaveAsync();
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
                _entityToEdit = await _inspection.Get(GetIdCurrentRow());
                EditBtn.Text = "Cancelar";

                cbFuelQuantity.SelectedItem = _entityToEdit.FuelQuantity;
                cbIsGrated.Checked = _entityToEdit.IsGrated;
                cbHasBrokenMirror.Checked = _entityToEdit.HasBrokenMirror;
                cbHasHydraulicCat.Checked = _entityToEdit.HasHydraulicCat;
                cbHasSpareTire.Checked = _entityToEdit.HasSpareTire;
                dpDate.Value = _entityToEdit.Date;
                cbStatus.SelectedItem = _entityToEdit.Status;

            }

            DeleteBtn.Enabled = !DeleteBtn.Enabled;
            rentDataGrid.Enabled = !rentDataGrid.Enabled;
            inspectionDataGrid.Enabled = !inspectionDataGrid.Enabled;

            _editionMode = !_editionMode;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (rentDataGrid == null) return;

            if (_editionMode)
            {
                string msj = $"Esta seguro que quiere editar el registro #{_entityToEdit.Id}? Esta acción no se podra deshacer.";
                DialogResult dialogResult = MessageBox.Show(msj, "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult != DialogResult.Yes)
                    return;

                await SaveEntity(true);
                await EditionModeToggle();
                await RefreshGridView();
            }
            else
            {
                await SaveEntity(false);
                await RefreshGridView();
                _gridViewLastSelectedRowIndex = rentDataGrid.Rows.Count - 1;
            }

            rentDataGrid.FirstDisplayedScrollingRowIndex = _gridViewLastSelectedRowIndex;

            CleanForm();
        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            if (inspectionDataGrid == null) return;

            await EditionModeToggle();
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (inspectionDataGrid.CurrentRow == null) return;

            var id = GetIdCurrentRow();

            DialogResult dialogResult = MessageBox.Show($"Esta seguro que quiere eliminar el registro #{id}?", "Eliminar",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                await DeleteEntity(id);
                await RefreshGridView();
            }

            inspectionDataGrid.FirstDisplayedScrollingRowIndex = _gridViewLastSelectedRowIndex;
        }
    }
}
