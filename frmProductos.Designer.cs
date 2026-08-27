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
            components = new System.ComponentModel.Container();
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
            txtCantidadStock = new TextBox();
            lblCantidadStock = new Label();
            txtRutaImagen = new TextBox();
            lblRutaImagen = new Label();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            btnActualizar = new Button();
            btnSalir = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblAdministracionProductos
            // 
            lblAdministracionProductos.AutoSize = true;
            lblAdministracionProductos.BackColor = Color.Transparent;
            lblAdministracionProductos.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdministracionProductos.ForeColor = Color.White;
            lblAdministracionProductos.Location = new Point(190, 25);
            lblAdministracionProductos.Name = "lblAdministracionProductos";
            lblAdministracionProductos.Size = new Size(456, 45);
            lblAdministracionProductos.TabIndex = 0;
            lblAdministracionProductos.Text = "Administración de Productos";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Segoe UI", 11F);
            lblNombreProducto.ForeColor = Color.White;
            lblNombreProducto.Location = new Point(93, 116);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(128, 20);
            lblNombreProducto.TabIndex = 1;
            lblNombreProducto.Text = "Nombre Producto";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(246, 113);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(122, 23);
            txtNombreProducto.TabIndex = 2;
            // 
            // txtCodigoReferencia
            // 
            txtCodigoReferencia.Location = new Point(246, 163);
            txtCodigoReferencia.Name = "txtCodigoReferencia";
            txtCodigoReferencia.Size = new Size(122, 23);
            txtCodigoReferencia.TabIndex = 4;
            // 
            // lblCodigoReferencia
            // 
            lblCodigoReferencia.AutoSize = true;
            lblCodigoReferencia.Font = new Font("Segoe UI", 11F);
            lblCodigoReferencia.ForeColor = Color.White;
            lblCodigoReferencia.Location = new Point(93, 166);
            lblCodigoReferencia.Name = "lblCodigoReferencia";
            lblCodigoReferencia.Size = new Size(153, 20);
            lblCodigoReferencia.TabIndex = 3;
            lblCodigoReferencia.Text = "Código de Referencia";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(246, 261);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(122, 23);
            txtPrecioVenta.TabIndex = 8;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Font = new Font("Segoe UI", 11F);
            lblPrecioVenta.ForeColor = Color.White;
            lblPrecioVenta.Location = new Point(93, 264);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(112, 20);
            lblPrecioVenta.TabIndex = 7;
            lblPrecioVenta.Text = "Precio de Venta";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(246, 211);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(122, 23);
            txtPrecioCompra.TabIndex = 6;
            // 
            // lblPreciocompra
            // 
            lblPreciocompra.AutoSize = true;
            lblPreciocompra.Font = new Font("Segoe UI", 11F);
            lblPreciocompra.ForeColor = Color.White;
            lblPreciocompra.Location = new Point(93, 214);
            lblPreciocompra.Name = "lblPreciocompra";
            lblPreciocompra.Size = new Size(128, 20);
            lblPreciocompra.TabIndex = 5;
            lblPreciocompra.Text = "Precio de Compra";
            // 
            // txtDetallesProducto
            // 
            txtDetallesProducto.Location = new Point(421, 261);
            txtDetallesProducto.Multiline = true;
            txtDetallesProducto.Name = "txtDetallesProducto";
            txtDetallesProducto.Size = new Size(249, 73);
            txtDetallesProducto.TabIndex = 12;
            // 
            // lblDetallesProducto
            // 
            lblDetallesProducto.AutoSize = true;
            lblDetallesProducto.Font = new Font("Segoe UI", 11F);
            lblDetallesProducto.ForeColor = Color.White;
            lblDetallesProducto.Location = new Point(421, 229);
            lblDetallesProducto.Name = "lblDetallesProducto";
            lblDetallesProducto.Size = new Size(152, 20);
            lblDetallesProducto.TabIndex = 11;
            lblDetallesProducto.Text = "Detalles del Producto";
            // 
            // txtCantidadStock
            // 
            txtCantidadStock.Location = new Point(246, 311);
            txtCantidadStock.Name = "txtCantidadStock";
            txtCantidadStock.Size = new Size(122, 23);
            txtCantidadStock.TabIndex = 10;
            // 
            // lblCantidadStock
            // 
            lblCantidadStock.AutoSize = true;
            lblCantidadStock.Font = new Font("Segoe UI", 11F);
            lblCantidadStock.ForeColor = Color.White;
            lblCantidadStock.Location = new Point(93, 314);
            lblCantidadStock.Name = "lblCantidadStock";
            lblCantidadStock.Size = new Size(130, 20);
            lblCantidadStock.TabIndex = 9;
            lblCantidadStock.Text = "Cantidad de Stock";
            // 
            // txtRutaImagen
            // 
            txtRutaImagen.Location = new Point(541, 168);
            txtRutaImagen.Name = "txtRutaImagen";
            txtRutaImagen.Size = new Size(129, 23);
            txtRutaImagen.TabIndex = 16;
            // 
            // lblRutaImagen
            // 
            lblRutaImagen.AutoSize = true;
            lblRutaImagen.Font = new Font("Segoe UI", 11F);
            lblRutaImagen.ForeColor = Color.White;
            lblRutaImagen.Location = new Point(421, 167);
            lblRutaImagen.Name = "lblRutaImagen";
            lblRutaImagen.Size = new Size(114, 20);
            lblRutaImagen.TabIndex = 15;
            lblRutaImagen.Text = "Ruta de Imagen";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 11F);
            lblCategoria.ForeColor = Color.White;
            lblCategoria.Location = new Point(421, 117);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 13;
            lblCategoria.Text = "Categoría";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(541, 116);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(129, 23);
            cmbCategoria.TabIndex = 17;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Highlight;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 11F);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(246, 370);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(88, 34);
            btnActualizar.TabIndex = 18;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Highlight;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(489, 370);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 34);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(cmbCategoria);
            Controls.Add(txtRutaImagen);
            Controls.Add(lblRutaImagen);
            Controls.Add(lblCategoria);
            Controls.Add(txtDetallesProducto);
            Controls.Add(lblDetallesProducto);
            Controls.Add(txtCantidadStock);
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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private TextBox txtCantidadStock;
        private Label lblCantidadStock;
        private TextBox txtRutaImagen;
        private Label lblRutaImagen;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Button btnActualizar;
        private Button btnSalir;
        private ErrorProvider errorProvider1;
    }
}