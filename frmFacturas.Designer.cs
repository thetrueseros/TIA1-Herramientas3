namespace TIA1
{
    partial class frmFacturas
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
            label1 = new Label();
            lblNroFactura = new Label();
            txtNroFactura = new TextBox();
            lblCliente = new Label();
            cmbCliente = new ComboBox();
            cmbEmpleado = new ComboBox();
            lblEmpleado = new Label();
            txtDescuento = new TextBox();
            lblDescuento = new Label();
            txtTotalIVA = new TextBox();
            lblTotalIva = new Label();
            txtTotalFactura = new TextBox();
            lblTotalFactura = new Label();
            lblFechaRegistro = new Label();
            dtpFechaRegistro = new DateTimePicker();
            lblEstadoFactura = new Label();
            cmbEstadoFactura = new ComboBox();
            lblDetalleFactura = new Label();
            txtDetalleFactura = new TextBox();
            btnActualizar = new Button();
            btnSalir = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(177, 19);
            label1.Name = "label1";
            label1.Size = new Size(474, 45);
            label1.TabIndex = 0;
            label1.Text = "ADMINISTRACIÓN FACTURAS";
            // 
            // lblNroFactura
            // 
            lblNroFactura.AutoSize = true;
            lblNroFactura.Font = new Font("Segoe UI", 11.25F);
            lblNroFactura.ForeColor = Color.White;
            lblNroFactura.Location = new Point(61, 92);
            lblNroFactura.Name = "lblNroFactura";
            lblNroFactura.Size = new Size(83, 20);
            lblNroFactura.TabIndex = 1;
            lblNroFactura.Text = "N°- Factura";
            // 
            // txtNroFactura
            // 
            txtNroFactura.Location = new Point(162, 89);
            txtNroFactura.Name = "txtNroFactura";
            txtNroFactura.Size = new Size(121, 23);
            txtNroFactura.TabIndex = 2;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 11.25F);
            lblCliente.ForeColor = Color.White;
            lblCliente.Location = new Point(61, 131);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(162, 128);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(121, 23);
            cmbCliente.TabIndex = 4;
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(162, 170);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(121, 23);
            cmbEmpleado.TabIndex = 6;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 11.25F);
            lblEmpleado.ForeColor = Color.White;
            lblEmpleado.Location = new Point(61, 173);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(77, 20);
            lblEmpleado.TabIndex = 5;
            lblEmpleado.Text = "Empleado";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(162, 209);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(121, 23);
            txtDescuento.TabIndex = 8;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI", 11.25F);
            lblDescuento.ForeColor = Color.White;
            lblDescuento.Location = new Point(61, 212);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(79, 20);
            lblDescuento.TabIndex = 7;
            lblDescuento.Text = "Descuento";
            // 
            // txtTotalIVA
            // 
            txtTotalIVA.Location = new Point(162, 253);
            txtTotalIVA.Name = "txtTotalIVA";
            txtTotalIVA.Size = new Size(121, 23);
            txtTotalIVA.TabIndex = 10;
            // 
            // lblTotalIva
            // 
            lblTotalIva.AutoSize = true;
            lblTotalIva.Font = new Font("Segoe UI", 11.25F);
            lblTotalIva.ForeColor = Color.White;
            lblTotalIva.Location = new Point(61, 256);
            lblTotalIva.Name = "lblTotalIva";
            lblTotalIva.Size = new Size(68, 20);
            lblTotalIva.TabIndex = 9;
            lblTotalIva.Text = "Total IVA";
            // 
            // txtTotalFactura
            // 
            txtTotalFactura.Location = new Point(162, 294);
            txtTotalFactura.Name = "txtTotalFactura";
            txtTotalFactura.Size = new Size(121, 23);
            txtTotalFactura.TabIndex = 12;
            // 
            // lblTotalFactura
            // 
            lblTotalFactura.AutoSize = true;
            lblTotalFactura.Font = new Font("Segoe UI", 11.25F);
            lblTotalFactura.ForeColor = Color.White;
            lblTotalFactura.Location = new Point(61, 297);
            lblTotalFactura.Name = "lblTotalFactura";
            lblTotalFactura.Size = new Size(93, 20);
            lblTotalFactura.TabIndex = 11;
            lblTotalFactura.Text = "Total Factura";
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Font = new Font("Segoe UI", 11.25F);
            lblFechaRegistro.ForeColor = Color.White;
            lblFechaRegistro.Location = new Point(341, 88);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(106, 20);
            lblFechaRegistro.TabIndex = 13;
            lblFechaRegistro.Text = "Fecha Registro";
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            dtpFechaRegistro.Location = new Point(341, 110);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(200, 23);
            dtpFechaRegistro.TabIndex = 14;
            // 
            // lblEstadoFactura
            // 
            lblEstadoFactura.AutoSize = true;
            lblEstadoFactura.Font = new Font("Segoe UI", 11.25F);
            lblEstadoFactura.ForeColor = Color.White;
            lblEstadoFactura.Location = new Point(341, 145);
            lblEstadoFactura.Name = "lblEstadoFactura";
            lblEstadoFactura.Size = new Size(105, 20);
            lblEstadoFactura.TabIndex = 15;
            lblEstadoFactura.Text = "Estado Factura";
            // 
            // cmbEstadoFactura
            // 
            cmbEstadoFactura.FormattingEnabled = true;
            cmbEstadoFactura.Location = new Point(341, 173);
            cmbEstadoFactura.Name = "cmbEstadoFactura";
            cmbEstadoFactura.Size = new Size(121, 23);
            cmbEstadoFactura.TabIndex = 16;
            // 
            // lblDetalleFactura
            // 
            lblDetalleFactura.AutoSize = true;
            lblDetalleFactura.Font = new Font("Segoe UI", 11.25F);
            lblDetalleFactura.ForeColor = Color.White;
            lblDetalleFactura.Location = new Point(341, 212);
            lblDetalleFactura.Name = "lblDetalleFactura";
            lblDetalleFactura.Size = new Size(108, 20);
            lblDetalleFactura.TabIndex = 17;
            lblDetalleFactura.Text = "Detalle Factura";
            // 
            // txtDetalleFactura
            // 
            txtDetalleFactura.Location = new Point(341, 234);
            txtDetalleFactura.Multiline = true;
            txtDetalleFactura.Name = "txtDetalleFactura";
            txtDetalleFactura.Size = new Size(291, 83);
            txtDetalleFactura.TabIndex = 18;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Highlight;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 11.25F);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(688, 112);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(96, 36);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Highlight;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 11.25F);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(688, 251);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(96, 36);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(825, 342);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(txtDetalleFactura);
            Controls.Add(lblDetalleFactura);
            Controls.Add(cmbEstadoFactura);
            Controls.Add(lblEstadoFactura);
            Controls.Add(dtpFechaRegistro);
            Controls.Add(lblFechaRegistro);
            Controls.Add(txtTotalFactura);
            Controls.Add(lblTotalFactura);
            Controls.Add(txtTotalIVA);
            Controls.Add(lblTotalIva);
            Controls.Add(txtDescuento);
            Controls.Add(lblDescuento);
            Controls.Add(cmbEmpleado);
            Controls.Add(lblEmpleado);
            Controls.Add(cmbCliente);
            Controls.Add(lblCliente);
            Controls.Add(txtNroFactura);
            Controls.Add(lblNroFactura);
            Controls.Add(label1);
            Name = "frmFacturas";
            Text = "Administración Facturas";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNroFactura;
        private TextBox txtNroFactura;
        private Label lblCliente;
        private ComboBox cmbCliente;
        private ComboBox cmbEmpleado;
        private Label lblEmpleado;
        private TextBox txtDescuento;
        private Label lblDescuento;
        private TextBox txtTotalIVA;
        private Label lblTotalIva;
        private TextBox txtTotalFactura;
        private Label lblTotalFactura;
        private Label lblFechaRegistro;
        private DateTimePicker dtpFechaRegistro;
        private Label lblEstadoFactura;
        private ComboBox cmbEstadoFactura;
        private Label lblDetalleFactura;
        private TextBox txtDetalleFactura;
        private Button btnActualizar;
        private Button btnSalir;
        private ErrorProvider errorProvider1;
    }
}