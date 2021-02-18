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
    public partial class VehicleTypeForm : Form
    {
        private GenericRepository<VehicleType> _vehicleType;
        private VehicleType _entityToEdit;
        private bool _editionMode;
        private int _gridViewLastSelectedRowIndex = 0;
        public VehicleTypeForm()
        {
            _vehicleType = new GenericRepository<VehicleType>();
            InitializeComponent();
        }

        private async void VehicleTypeCRUD_Load(object sender, EventArgs e)
        {
           await RefreshGridView();
           RefreshComboBoxes();
           CleanForm();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            _gridViewLastSelectedRowIndex = dataGridView1.CurrentRow.Index;
        }

        private async Task RefreshGridView()
        {
            var data = await _vehicleType.GetAll();
            dataGridView1.DataSource = data;
            dataGridView1.Columns[nameof(VehicleType.VehicleModel)].Visible = false;
        }
        private void RefreshComboBoxes()
        {
            cbStatus.DataSource = Enum.GetValues(typeof(StatusEnum));

        }
        private void CleanForm()
        {
            ActionControl.ClearTextBoxes(txtDescription);
            cbStatus.SelectedIndex = 0;
        }

        private async Task SaveEntity()
        {
            var vehicleType = new VehicleType()
            {
                Description = txtDescription.Text.Trim(),
                Status = (StatusEnum)cbStatus.SelectedItem
            };
            await _vehicleType.Add(vehicleType);
            await _vehicleType.SaveAsync();
        }
        private async Task UpdateEntity()
        {
            _entityToEdit.Description = txtDescription.Text;
            _entityToEdit.Status = (StatusEnum)cbStatus.SelectedItem;

            _vehicleType.Update(_entityToEdit);
            await _vehicleType.SaveAsync();
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
                    EditionModeToggle();
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

        private async Task DeleteEntity(VehicleType vehicleType)
        {
            await _vehicleType.Delete(vehicleType.Id);
            await _vehicleType.SaveAsync();
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            VehicleType vehicleType = (VehicleType)dataGridView1.CurrentRow.DataBoundItem;

            DialogResult dialogResult = MessageBox.Show($"Esta seguro que quiere eliminar el registro #{vehicleType.Id}?", "Eliminar",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                await DeleteEntity(vehicleType);
                await RefreshGridView();
            }
        }

        private void EditionModeToggle()
        {
            if (_editionMode)
            {
                EditBtn.Text = "Editar";
                _entityToEdit = null;
                CleanForm();
            }
            else
            {
                EditBtn.Text = "Cancelar modificacion";

                VehicleType vehicleType = (VehicleType)dataGridView1.CurrentRow.DataBoundItem;
                _entityToEdit = vehicleType;

                txtDescription.Text = vehicleType.Description;
                cbStatus.SelectedItem = vehicleType.Status;
            }

            DeleteBtn.Enabled = !DeleteBtn.Enabled;
            dataGridView1.Enabled = !dataGridView1.Enabled;
            
            _editionMode = !_editionMode;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            EditionModeToggle();
        }

    }
}
