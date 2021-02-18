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
using RentCarCenter.Services;
using RentCarCenter.Models.Base;

namespace RentCarCenter.Forms.Maintenance
{
    public partial class VehicleModelForm : Form
    {
        private GenericRepository<VehicleModel> _VehicleModel;
        private GenericRepository<VehicleType> _VehicleType;
        private GenericRepository<VehicleBrand> _VehicleBrand;
        private VehicleModel _entityToEdit;
        private bool _editionMode;
        private int _gridViewLastSelectedRowIndex = 0;

        public VehicleModelForm()
        {
            _VehicleModel = new GenericRepository<VehicleModel>();
            _VehicleBrand = new GenericRepository<VehicleBrand>();
            _VehicleType = new GenericRepository<VehicleType>();
            InitializeComponent();
        }

        private async void VehicleModelCRUD_Load(object sender, EventArgs e)
        {
           await RefreshGridView();
           await RefreshComboBoxes();
           CleanForm();
        }



        private async Task RefreshGridView()
        {
            var data = await _VehicleModel.GetAll(nameof(VehicleBrand),nameof(VehicleType));

            dataGridView1.DataSource = data.Select( d => new {
                d.Id,
                d.Description,
                VehicleType = d.VehicleType.Description,
                VehicleBrand = d.VehicleBrand.Description,
                d.Status
            }).ToList();
        }

        private async Task RefreshComboBoxes()
        {
            cbType.DataSource = (await _VehicleType.GetAll()).Where(vt => vt.Status == StatusEnum.Activado).ToList();
            cbType.ValueMember = nameof(VehicleType.Id);
            cbType.DisplayMember = nameof(VehicleType.Description);

            cbBrand.DataSource = (await _VehicleBrand.GetAll()).Where(vb => vb.Status == StatusEnum.Activado).ToList();
            cbBrand.ValueMember = nameof(VehicleBrand.Id);
            cbBrand.DisplayMember = nameof(VehicleBrand.Description);

            cbStatus.DataSource = Enum.GetValues(typeof(StatusEnum));

        }

        private void CleanForm()
        {
            ActionControl.ClearTextBoxes(txtDescription);
            cbStatus.SelectedIndex = 0;

            if (cbBrand.Items.Count > 0)
                cbBrand.SelectedIndex = 0;
            if (cbType.Items.Count > 0)
                cbType.SelectedIndex = 0;
        }

        private async Task SaveEntity()
        {
            var VehicleModel = new VehicleModel()
            {
                Description = txtDescription.Text.Trim(),
                Status = (StatusEnum)cbStatus.SelectedItem,
                VehicleBrandId = int.TryParse(cbBrand.SelectedValue.ToString(), out int idVehicleBrand) ? idVehicleBrand : 0,
                VehicleTypeId = int.TryParse(cbType.SelectedValue.ToString(), out int idVehicleType) ? idVehicleType : 0
            };
            await _VehicleModel.Add(VehicleModel);
            await _VehicleModel.SaveAsync();
        }
        private async Task UpdateEntity()
        {
            _entityToEdit.Description = txtDescription.Text.Trim();
            _entityToEdit.Status = (StatusEnum)cbStatus.SelectedItem;
            _entityToEdit.VehicleBrandId = int.TryParse(cbBrand.SelectedValue.ToString(), out int idVehicleBrand) ? idVehicleBrand : 0;
            _entityToEdit.VehicleTypeId = int.TryParse(cbType.SelectedValue.ToString(), out int idVehicleType) ? idVehicleType : 0;

            _VehicleModel.Update(_entityToEdit);
            await _VehicleModel.SaveAsync();
        }

        private bool IsFormValid()
        {
            return txtDescription.Text.Trim().Length > 0 && txtDescription.Text.Trim().Length <= 200;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsFormValid())
            {
                string msj = "De lo mio, ten en cuenta que no me puedes de dejar la descripcion vacia.";
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
            await _VehicleModel.Delete(Id);
            await _VehicleModel.SaveAsync();
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

                _entityToEdit = await _VehicleModel.Get(GetIdCurrentRow());
                txtDescription.Text = _entityToEdit.Description;
                cbType.SelectedValue = _entityToEdit.VehicleTypeId;
                cbBrand.SelectedValue = _entityToEdit.VehicleBrandId;
                cbStatus.SelectedItem = _entityToEdit.Status;
                
            }

            DeleteBtn.Enabled = !DeleteBtn.Enabled;
            dataGridView1.Enabled = !dataGridView1.Enabled;
            
            _editionMode = !_editionMode;
        }

        private int GetIdCurrentRow()
        {
            return int.TryParse(dataGridView1.CurrentRow.Cells[nameof(VehicleModel.Id)].Value.ToString(), out int id) ? id : 0;
        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            await EditionModeToggle();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            _gridViewLastSelectedRowIndex = dataGridView1.CurrentRow.Index;
        }
    }
}
