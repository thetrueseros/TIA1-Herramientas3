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
    public partial class frmFacturas : Form
    {
        public frmFacturas()
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
            // N° factura vacio
            if (string.IsNullOrEmpty(txtNroFactura.Text))
            {
                errorProvider1.SetError(txtNroFactura, "Debe ingresar un número de factura.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNroFactura, "");
            }

            //descuento vacio
            if (string.IsNullOrEmpty(txtDescuento.Text)) 
            {
                errorProvider1.SetError(txtDescuento, "Debe ingresar un porcentaje de descuento.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtDescuento, "");
            }

            //total iva vacio
            if (string.IsNullOrEmpty(txtTotalIVA.Text))
            {
                errorProvider1.SetError(txtTotalIVA, "Debe ingresar el valor del Impuesto al Valor Tributario");
                return;
            }
            else
            {
                errorProvider1.SetError(txtTotalIVA, "");
            }

            //total factura vacio
            if (string.IsNullOrEmpty(txtTotalFactura.Text))
            {
                errorProvider1.SetError(txtTotalFactura, "Debe ingresar el valor total de la factura.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtTotalFactura, "");
            }
        }
    }
}
