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
    public partial class frmProductos : Form
    {
        public frmProductos()
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
            // nombre producto vacío
            if (string.IsNullOrEmpty(txtNombreProducto.Text))
            {
                errorProvider1.SetError(txtNombreProducto, "El nombre del producto no puede estar vacío.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombreProducto, "");
            }

            // código de referencia vacío
            if (string.IsNullOrEmpty(txtCodigoReferencia.Text))
            {
                errorProvider1.SetError(txtCodigoReferencia, "El código de referencia no puede estar vacío.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCodigoReferencia, "");
            }

            //precio de compra vacio
            if (string.IsNullOrEmpty(txtPrecioCompra.Text))
            {
                errorProvider1.SetError(txtPrecioCompra, "El precio de compra no puede estar vacío.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPrecioCompra, "");
            }

            //precio de venta vacio
            if (string.IsNullOrEmpty(txtNombreProducto.Text))
            {
                errorProvider1.SetError(txtPrecioVenta, "El precio de venta no puede estar vacío.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPrecioVenta, "");
            }

            // cantidad de stock vacía
            if (string.IsNullOrEmpty(txtCantidadStock.Text))
            {
                errorProvider1.SetError(txtCantidadStock, "La cantidad de stock no puede estar vacía");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCantidadStock, "");
            }

            //ruta de immagen vacía
            if (string.IsNullOrEmpty(txtRutaImagen.Text))
            {
                errorProvider1.SetError(txtRutaImagen, "La ruta de la imagen del producto no puede estar vacía");
                return;
            }
            else
            {
                errorProvider1.SetError(txtRutaImagen, "");
            }
        }
    }
}
