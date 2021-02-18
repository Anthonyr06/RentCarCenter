using RentCarCenter.Forms.Maintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RentCarCenter.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void OpenChild(Form form)
        {
            foreach (Form item in Application.OpenForms)
                if (item.GetType().Name == form.Name)
                    return;
                    
            form.Show();
                
        }

        private void btnNewRent_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNewInspection_Click(object sender, EventArgs e)
        {

        }

        private void btnNewReturn_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenChild(new Rents());
        }

        private void btnVehiclesType_Click(object sender, EventArgs e)
        {
            OpenChild(new VehicleTypeForm());
        }

        private void btnVehiclesBrand_Click(object sender, EventArgs e)
        {
            OpenChild(new VehicleBrandForm());
        }

        private void BtnFuelType_Click(object sender, EventArgs e)
        {
            OpenChild(new FuelTypeForm());
        }

        private void btnVehicleModels_Click(object sender, EventArgs e)
        {
            OpenChild(new VehicleModelForm());
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            OpenChild(new VehicleForm());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChild(new CustomerForm());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenChild(new EmployeeForm());
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
