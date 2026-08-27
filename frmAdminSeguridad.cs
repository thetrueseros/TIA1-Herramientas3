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
    public partial class frmAdminSeguridad : Form
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea salir de este apartado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // usuario vacío
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                errorProvider1.SetError(txtUsuario, "El campo de usuario es obligatorio.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUsuario, "");
            }

            //contraseña vacía

            if (string.IsNullOrEmpty(txtContrasena.Text))
            {
                errorProvider1.SetError(txtContrasena, "El campo de contraseña es obligatorio.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtContrasena, "");
            }
        }
    }
}
