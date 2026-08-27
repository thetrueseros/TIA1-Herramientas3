using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIA1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            // usuario vacío
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                errorProvider1.SetError(txtUsuario, "El nombre es obligatorio.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUsuario, "");
            }

            //contraseña vacía
            if (String.IsNullOrEmpty(txtContraseña.Text))
            {
                errorProvider1.SetError(txtContraseña, "La contraseña es obligatoria.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtContraseña, "");
            }
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
