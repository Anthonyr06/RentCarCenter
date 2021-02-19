using RentCarCenter.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarCenter.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == string.Empty || txtPwd.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe de llenar todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtUser.Text.Trim() != "Anthony" || txtPwd.Text.Trim() != "20200671")
            {
               MessageBox.Show("Los datos son incorrectos. Intentelo nuevamente", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var home = new Home();
            home.Show();

            Hide();
        }
    }
}
