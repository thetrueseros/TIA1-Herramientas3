namespace TIA1
{
    partial class frmClientes
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
            lblNuevoRegistroClientes = new Label();
            lblNombreCliente = new Label();
            txtNombreCliente = new TextBox();
            txtDocumento = new TextBox();
            lblDocumento = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtEmail = new TextBox();
            btnSalir = new Button();
            btnActualizar = new Button();
            lblEmail = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblNuevoRegistroClientes
            // 
            lblNuevoRegistroClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNuevoRegistroClientes.AutoSize = true;
            lblNuevoRegistroClientes.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblNuevoRegistroClientes.ForeColor = Color.White;
            lblNuevoRegistroClientes.Location = new Point(62, 9);
            lblNuevoRegistroClientes.Name = "lblNuevoRegistroClientes";
            lblNuevoRegistroClientes.Size = new Size(451, 46);
            lblNuevoRegistroClientes.TabIndex = 0;
            lblNuevoRegistroClientes.Text = "NUEVO REGISTRO CLIENTE";
            lblNuevoRegistroClientes.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new Font("Segoe UI", 11F);
            lblNombreCliente.ForeColor = Color.White;
            lblNombreCliente.Location = new Point(80, 101);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(114, 20);
            lblNombreCliente.TabIndex = 1;
            lblNombreCliente.Text = "Nombre Cliente";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(223, 98);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(253, 23);
            txtNombreCliente.TabIndex = 2;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(223, 143);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(253, 23);
            txtDocumento.TabIndex = 4;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 11F);
            lblDocumento.ForeColor = Color.White;
            lblDocumento.Location = new Point(80, 146);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(87, 20);
            lblDocumento.TabIndex = 3;
            lblDocumento.Text = "Documento";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(223, 234);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(253, 23);
            txtTelefono.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 11F);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(80, 237);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Teléfono";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(223, 189);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(253, 23);
            txtDireccion.TabIndex = 6;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 11F);
            lblDireccion.ForeColor = Color.White;
            lblDireccion.Location = new Point(80, 192);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 5;
            lblDireccion.Text = "Dirección";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(223, 281);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 23);
            txtEmail.TabIndex = 10;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Highlight;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(371, 338);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(105, 35);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Highlight;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 11F);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(93, 338);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(105, 35);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(80, 284);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(562, 424);
            Controls.Add(btnActualizar);
            Controls.Add(btnSalir);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumento);
            Controls.Add(txtNombreCliente);
            Controls.Add(lblNombreCliente);
            Controls.Add(lblNuevoRegistroClientes);
            ForeColor = Color.White;
            Name = "frmClientes";
            Text = "Nuevo Registro de Cliente";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNuevoRegistroClientes;
        private Label lblNombreCliente;
        private TextBox txtNombreCliente;
        private TextBox txtDocumento;
        private Label lblDocumento;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtEmail;
        private Button btnSalir;
        private Button btnActualizar;
        private Label lblEmail;
        private ErrorProvider errorProvider1;
    }
}