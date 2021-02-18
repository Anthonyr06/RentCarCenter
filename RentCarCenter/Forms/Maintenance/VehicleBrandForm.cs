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
    public partial class VehicleBrandForm : Form
    {
        private GenericRepository<VehicleBrand> _VehicleBrand;
        private VehicleBrand _EntityToEdit;
        private bool _editionMode;
        private int _gridViewLastSelectedRowIndex = 0;
        public VehicleBrandForm()
        {
            _VehicleBrand = new GenericRepository<VehicleBrand>();
            InitializeComponent();
        }

        private async void VehicleBrandCRUD_Load(object sender, EventArgs e)
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
            var data = await _VehicleBrand.GetAll();
            dataGridView1.DataSource = data;
            dataGridView1.Columns[nameof(VehicleBrand.VehicleModel)].Visible = false;
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
            var VehicleBrand = new VehicleBrand()
            {
                Description = txtDescription.Text.Trim(),
                Status = (StatusEnum)cbStatus.SelectedItem
            };
            await _VehicleBrand.Add(VehicleBrand);
            await _VehicleBrand.SaveAsync();
        }
        private async Task UpdateEntity()
        {
            _EntityToEdit.Description = txtDescription.Text;
            _EntityToEdit.Status = (StatusEnum)cbStatus.SelectedItem;

            _VehicleBrand.Update(_EntityToEdit);
            await _VehicleBrand.SaveAsync();
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
                string msj = $"Esta seguro que quiere editar el registro #{_EntityToEdit.Id}? Esta acción no se podra deshacer.";
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

        private async Task DeleteEntity(VehicleBrand VehicleBrand)
        {
            await _VehicleBrand.Delete(VehicleBrand.Id);
            await _VehicleBrand.SaveAsync();
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            VehicleBrand VehicleBrand = (VehicleBrand)dataGridView1.CurrentRow.DataBoundItem;

            DialogResult dialogResult = MessageBox.Show($"Esta seguro que quiere eliminar el registro #{VehicleBrand.Id}?", "Eliminar",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                await DeleteEntity(VehicleBrand);
                await RefreshGridView();
            }

            dataGridView1.FirstDisplayedScrollingRowIndex = _gridViewLastSelectedRowIndex;

        }

        private void EditionModeToggle()
        {
            if (_editionMode)
            {
                EditBtn.Text = "Editar";
                _EntityToEdit = null;
                CleanForm();
            }
            else
            {
                EditBtn.Text = "Cancelar modificacion";

                VehicleBrand VehicleBrand = (VehicleBrand)dataGridView1.CurrentRow.DataBoundItem;
                _EntityToEdit = VehicleBrand;

                txtDescription.Text = VehicleBrand.Description;
                cbStatus.SelectedItem = VehicleBrand.Status;
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
