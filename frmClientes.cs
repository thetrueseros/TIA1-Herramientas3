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
    public partial class frmClientes : Form
    {
        public frmClientes()
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
            //nombre vacío
            if (string.IsNullOrEmpty(txtNombreCliente.Text))
            {
                errorProvider1.SetError(txtNombreCliente, "El campo de nombre de cliente es obligatorio.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombreCliente, "");
            }

            //documento vacío
            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                errorProvider1.SetError(txtDocumento, "El campo de documento es obligatorio.");
                return;

            }
            else
            {
                errorProvider1.SetError(txtDocumento, "");
            }

            //direccion vacía
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                errorProvider1.SetError(txtDireccion, "El campo de dirección es obligatorio.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtDireccion, "");
            }

            //telefono vacío
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                errorProvider1.SetError(txtTelefono, "El campo de teléfono es obligatorio.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtTelefono, "");
            }

            //email vacio
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "El campo de email es obligatorio.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }
    }
}
