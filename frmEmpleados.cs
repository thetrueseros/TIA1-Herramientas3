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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
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
            // nombre vacio
            if (string.IsNullOrEmpty(txtNombreEmpleado.Text))
            {
                errorProvider1.SetError(txtNombreEmpleado, "El nombre del empleado es obligatorio.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombreEmpleado, "");
            }

            //documento vacio
            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                errorProvider1.SetError(txtDocumento, "El documento del empleado es obligatorio.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtDocumento, "");
            }

            //direccion vacía
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                errorProvider1.SetError(txtDireccion, "La dirección del empleado es obligatoria.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtDireccion, "");
            }

            //telefono vacío
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                errorProvider1.SetError(txtTelefono, "El teléfono del empleado es obligatorio.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtTelefono, "");
            }

            //email vacio
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "El correo electrónico del empleado es obligatorio.");
                return;

            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }
    }
}
