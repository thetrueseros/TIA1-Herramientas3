namespace TIA1
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAdministracionProductos = new Label();
            lblNombreProducto = new Label();
            txtNombreProducto = new TextBox();
            txtCodigoReferencia = new TextBox();
            lblCodigoReferencia = new Label();
            txtPrecioVenta = new TextBox();
            lblPrecioVenta = new Label();
            txtPrecioCompra = new TextBox();
            lblPreciocompra = new Label();
            txtDetallesProducto = new TextBox();
            lblDetallesProducto = new Label();
            textBox6 = new TextBox();
            lblCantidadStock = new Label();
            txtRutaImagen = new TextBox();
            lblRutaImagen = new Label();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            btnActualizar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblAdministracionProductos
            // 
            lblAdministracionProductos.AutoSize = true;
            lblAdministracionProductos.Font = new Font("Segoe UI", 20F);
            lblAdministracionProductos.Location = new Point(219, 28);
            lblAdministracionProductos.Name = "lblAdministracionProductos";
            lblAdministracionProductos.Size = new Size(358, 37);
            lblAdministracionProductos.TabIndex = 0;
            lblAdministracionProductos.Text = "Administración de Productos";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(93, 116);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(103, 15);
            lblNombreProducto.TabIndex = 1;
            lblNombreProducto.Text = "Nombre Producto";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(237, 113);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(100, 23);
            txtNombreProducto.TabIndex = 2;
            txtNombreProducto.TextChanged += this.textBox1_TextChanged;
            // 
            // txtCodigoReferencia
            // 
            txtCodigoReferencia.Location = new Point(237, 163);
            txtCodigoReferencia.Name = "txtCodigoReferencia";
            txtCodigoReferencia.Size = new Size(100, 23);
            txtCodigoReferencia.TabIndex = 4;
            txtCodigoReferencia.TextChanged += this.textBox2_TextChanged;
            // 
            // lblCodigoReferencia
            // 
            lblCodigoReferencia.AutoSize = true;
            lblCodigoReferencia.Location = new Point(93, 166);
            lblCodigoReferencia.Name = "lblCodigoReferencia";
            lblCodigoReferencia.Size = new Size(120, 15);
            lblCodigoReferencia.TabIndex = 3;
            lblCodigoReferencia.Text = "Código de Referencia";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(237, 261);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(100, 23);
            txtPrecioVenta.TabIndex = 8;
            txtPrecioVenta.TextChanged += this.textBox3_TextChanged;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(93, 264);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(88, 15);
            lblPrecioVenta.TabIndex = 7;
            lblPrecioVenta.Text = "Precio de Venta";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(237, 211);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(100, 23);
            txtPrecioCompra.TabIndex = 6;
            txtPrecioCompra.TextChanged += this.textBox4_TextChanged;
            // 
            // lblPreciocompra
            // 
            lblPreciocompra.AutoSize = true;
            lblPreciocompra.Location = new Point(93, 214);
            lblPreciocompra.Name = "lblPreciocompra";
            lblPreciocompra.Size = new Size(102, 15);
            lblPreciocompra.TabIndex = 5;
            lblPreciocompra.Text = "Precio de Compra";
            // 
            // txtDetallesProducto
            // 
            txtDetallesProducto.Location = new Point(421, 261);
            txtDetallesProducto.Multiline = true;
            txtDetallesProducto.Name = "txtDetallesProducto";
            txtDetallesProducto.Size = new Size(225, 50);
            txtDetallesProducto.TabIndex = 12;
            txtDetallesProducto.TextChanged += textBox5_TextChanged;
            // 
            // lblDetallesProducto
            // 
            lblDetallesProducto.AutoSize = true;
            lblDetallesProducto.Location = new Point(421, 229);
            lblDetallesProducto.Name = "lblDetallesProducto";
            lblDetallesProducto.Size = new Size(119, 15);
            lblDetallesProducto.TabIndex = 11;
            lblDetallesProducto.Text = "Detalles del Producto";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(237, 311);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 10;
            textBox6.TextChanged += this.textBox6_TextChanged;
            // 
            // lblCantidadStock
            // 
            lblCantidadStock.AutoSize = true;
            lblCantidadStock.Location = new Point(93, 314);
            lblCantidadStock.Name = "lblCantidadStock";
            lblCantidadStock.Size = new Size(103, 15);
            lblCantidadStock.TabIndex = 9;
            lblCantidadStock.Text = "Cantidad de Stock";
            // 
            // txtRutaImagen
            // 
            txtRutaImagen.Location = new Point(517, 167);
            txtRutaImagen.Name = "txtRutaImagen";
            txtRutaImagen.Size = new Size(129, 23);
            txtRutaImagen.TabIndex = 16;
            // 
            // lblRutaImagen
            // 
            lblRutaImagen.AutoSize = true;
            lblRutaImagen.Location = new Point(421, 167);
            lblRutaImagen.Name = "lblRutaImagen";
            lblRutaImagen.Size = new Size(90, 15);
            lblRutaImagen.TabIndex = 15;
            lblRutaImagen.Text = "Ruta de Imagen";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(421, 117);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 13;
            lblCategoria.Text = "Categoría";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(517, 115);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(129, 23);
            cmbCategoria.TabIndex = 17;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(246, 370);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 18;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(489, 370);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(cmbCategoria);
            Controls.Add(txtRutaImagen);
            Controls.Add(lblRutaImagen);
            Controls.Add(lblCategoria);
            Controls.Add(txtDetallesProducto);
            Controls.Add(lblDetallesProducto);
            Controls.Add(textBox6);
            Controls.Add(lblCantidadStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(lblPrecioVenta);
            Controls.Add(txtPrecioCompra);
            Controls.Add(lblPreciocompra);
            Controls.Add(txtCodigoReferencia);
            Controls.Add(lblCodigoReferencia);
            Controls.Add(txtNombreProducto);
            Controls.Add(lblNombreProducto);
            Controls.Add(lblAdministracionProductos);
            Name = "frmProductos";
            Text = "Productos";
            Load += this.frmProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdministracionProductos;
        private Label lblNombreProducto;
        private TextBox txtNombreProducto;
        private TextBox txtCodigoReferencia;
        private Label lblCodigoReferencia;
        private TextBox txtPrecioVenta;
        private Label lblPrecioVenta;
        private TextBox txtPrecioCompra;
        private Label lblPreciocompra;
        private TextBox txtDetallesProducto;
        private Label lblDetallesProducto;
        private TextBox textBox6;
        private Label lblCantidadStock;
        private TextBox txtRutaImagen;
        private Label lblRutaImagen;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Button btnActualizar;
        private Button btnSalir;
    }
}