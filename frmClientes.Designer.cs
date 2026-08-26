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
            lblNuevoRegistroClientes = new Label();
            lblNombreCliente = new Label();
            txtNombreCliente = new TextBox();
            txtDocumento = new TextBox();
            lblDocumento = new Label();
            textBox1 = new TextBox();
            lblTelefono = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtEmail = new TextBox();
            btnSalir = new Button();
            btnActualizar = new Button();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // lblNuevoRegistroClientes
            // 
            lblNuevoRegistroClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNuevoRegistroClientes.AutoSize = true;
            lblNuevoRegistroClientes.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
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
            lblNombreCliente.Location = new Point(80, 101);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(91, 15);
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
            txtDocumento.TextChanged += textBox1_TextChanged;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(80, 146);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 3;
            lblDocumento.Text = "Documento";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(223, 234);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(80, 237);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
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
            lblDireccion.Location = new Point(80, 192);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
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
            btnSalir.Location = new Point(401, 338);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(123, 338);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(80, 284);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 424);
            Controls.Add(btnActualizar);
            Controls.Add(btnSalir);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(textBox1);
            Controls.Add(lblTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumento);
            Controls.Add(txtNombreCliente);
            Controls.Add(lblNombreCliente);
            Controls.Add(lblNuevoRegistroClientes);
            Name = "frmClientes";
            Text = "Nuevo Registro de Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNuevoRegistroClientes;
        private Label lblNombreCliente;
        private TextBox txtNombreCliente;
        private TextBox txtDocumento;
        private Label lblDocumento;
        private TextBox textBox1;
        private Label lblTelefono;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtEmail;
        private Button btnSalir;
        private Button btnActualizar;
        private Label lblEmail;
    }
}