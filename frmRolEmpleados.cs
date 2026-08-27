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
    public partial class frmRolEmpleados : Form
    {
        public frmRolEmpleados()
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
            //nombre rol vacío
            if (string.IsNullOrEmpty(txtNombreRol.Text))
            {
                errorProvider1.SetError(txtNombreRol, "El nombre del rol no puede estar vacío");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombreRol, "");
            }

            //descripcion detallada del rol vacía
            if (string.IsNullOrEmpty(txtDescripcionRol.Text)) 
            {
                errorProvider1.SetError(txtDescripcionRol, "La descripción del rol no puede estar vacía");
                return;
            }
            else
            {
                errorProvider1.SetError(txtDescripcionRol, "");
            }
        }
    }
}
