namespace TIA1
{
    partial class frmEmpleados
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
            lblAdministracionEmpleados = new Label();
            lblNombreEmpleado = new Label();
            txtNombreEmpleado = new TextBox();
            txtDocumento = new TextBox();
            lblDocumento = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtDatosAdicionales = new TextBox();
            lblDatosAdicionales = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblRolEmpleado = new Label();
            cmbRolEmpleado = new ComboBox();
            lblFechaIngreso = new Label();
            lblFechaRetiro = new Label();
            dtpFechaIngreso = new DateTimePicker();
            dtpFechaRetiro = new DateTimePicker();
            btnActualizar = new Button();
            btnSalir = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblAdministracionEmpleados
            // 
            lblAdministracionEmpleados.AutoSize = true;
            lblAdministracionEmpleados.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdministracionEmpleados.ForeColor = Color.White;
            lblAdministracionEmpleados.Location = new Point(23, 9);
            lblAdministracionEmpleados.Name = "lblAdministracionEmpleados";
            lblAdministracionEmpleados.Size = new Size(566, 45);
            lblAdministracionEmpleados.TabIndex = 0;
            lblAdministracionEmpleados.Text = "ADMINISTRACIÓN DE EMPLEADOS";
            // 
            // lblNombreEmpleado
            // 
            lblNombreEmpleado.AutoSize = true;
            lblNombreEmpleado.Font = new Font("Segoe UI", 11.25F);
            lblNombreEmpleado.ForeColor = Color.White;
            lblNombreEmpleado.Location = new Point(20, 84);
            lblNombreEmpleado.Name = "lblNombreEmpleado";
            lblNombreEmpleado.Size = new Size(136, 20);
            lblNombreEmpleado.TabIndex = 1;
            lblNombreEmpleado.Text = "Nombre Empleado";
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(162, 84);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(176, 23);
            txtNombreEmpleado.TabIndex = 2;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(162, 140);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(176, 23);
            txtDocumento.TabIndex = 4;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 11.25F);
            lblDocumento.ForeColor = Color.White;
            lblDocumento.Location = new Point(20, 136);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(87, 20);
            lblDocumento.TabIndex = 3;
            lblDocumento.Text = "Documento";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(162, 253);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(176, 23);
            txtTelefono.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 11.25F);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(20, 249);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Teléfono";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(162, 196);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(176, 23);
            txtDireccion.TabIndex = 6;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 11.25F);
            lblDireccion.ForeColor = Color.White;
            lblDireccion.Location = new Point(20, 192);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 5;
            lblDireccion.Text = "Dirección";
            // 
            // txtDatosAdicionales
            // 
            txtDatosAdicionales.Location = new Point(359, 242);
            txtDatosAdicionales.Multiline = true;
            txtDatosAdicionales.Name = "txtDatosAdicionales";
            txtDatosAdicionales.Size = new Size(230, 89);
            txtDatosAdicionales.TabIndex = 12;
            // 
            // lblDatosAdicionales
            // 
            lblDatosAdicionales.AutoSize = true;
            lblDatosAdicionales.Font = new Font("Segoe UI", 11.25F);
            lblDatosAdicionales.ForeColor = Color.White;
            lblDatosAdicionales.Location = new Point(359, 215);
            lblDatosAdicionales.Name = "lblDatosAdicionales";
            lblDatosAdicionales.Size = new Size(152, 20);
            lblDatosAdicionales.TabIndex = 11;
            lblDatosAdicionales.Text = "DATOS ADICIONALES";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(162, 311);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 23);
            txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11.25F);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(20, 307);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // lblRolEmpleado
            // 
            lblRolEmpleado.AutoSize = true;
            lblRolEmpleado.Font = new Font("Segoe UI", 11.25F);
            lblRolEmpleado.ForeColor = Color.White;
            lblRolEmpleado.Location = new Point(359, 84);
            lblRolEmpleado.Name = "lblRolEmpleado";
            lblRolEmpleado.Size = new Size(103, 20);
            lblRolEmpleado.TabIndex = 13;
            lblRolEmpleado.Text = "Rol Empleado";
            // 
            // cmbRolEmpleado
            // 
            cmbRolEmpleado.FormattingEnabled = true;
            cmbRolEmpleado.Location = new Point(468, 81);
            cmbRolEmpleado.Name = "cmbRolEmpleado";
            cmbRolEmpleado.Size = new Size(121, 23);
            cmbRolEmpleado.TabIndex = 14;
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Font = new Font("Segoe UI", 11.25F);
            lblFechaIngreso.ForeColor = Color.White;
            lblFechaIngreso.Location = new Point(359, 126);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(100, 20);
            lblFechaIngreso.TabIndex = 15;
            lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // lblFechaRetiro
            // 
            lblFechaRetiro.AutoSize = true;
            lblFechaRetiro.Font = new Font("Segoe UI", 11.25F);
            lblFechaRetiro.ForeColor = Color.White;
            lblFechaRetiro.Location = new Point(359, 173);
            lblFechaRetiro.Name = "lblFechaRetiro";
            lblFechaRetiro.Size = new Size(91, 20);
            lblFechaRetiro.TabIndex = 16;
            lblFechaRetiro.Text = "Fecha Retiro";
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Format = DateTimePickerFormat.Short;
            dtpFechaIngreso.Location = new Point(468, 120);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(121, 23);
            dtpFechaIngreso.TabIndex = 17;
            // 
            // dtpFechaRetiro
            // 
            dtpFechaRetiro.Format = DateTimePickerFormat.Short;
            dtpFechaRetiro.Location = new Point(468, 167);
            dtpFechaRetiro.Name = "dtpFechaRetiro";
            dtpFechaRetiro.Size = new Size(121, 23);
            dtpFechaRetiro.TabIndex = 18;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Highlight;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 11.25F);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(151, 364);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 30);
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
            btnSalir.Location = new Point(379, 364);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 30);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(638, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(dtpFechaRetiro);
            Controls.Add(dtpFechaIngreso);
            Controls.Add(lblFechaRetiro);
            Controls.Add(lblFechaIngreso);
            Controls.Add(cmbRolEmpleado);
            Controls.Add(lblRolEmpleado);
            Controls.Add(txtDatosAdicionales);
            Controls.Add(lblDatosAdicionales);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumento);
            Controls.Add(txtNombreEmpleado);
            Controls.Add(lblNombreEmpleado);
            Controls.Add(lblAdministracionEmpleados);
            Name = "frmEmpleados";
            Text = "Administración de Empleados";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdministracionEmpleados;
        private Label lblNombreEmpleado;
        private TextBox txtNombreEmpleado;
        private TextBox txtDocumento;
        private Label lblDocumento;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtDatosAdicionales;
        private Label lblDatosAdicionales;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblRolEmpleado;
        private ComboBox cmbRolEmpleado;
        private Label lblFechaIngreso;
        private Label lblFechaRetiro;
        private DateTimePicker dtpFechaIngreso;
        private DateTimePicker dtpFechaRetiro;
        private Button btnActualizar;
        private Button btnSalir;
        private ErrorProvider errorProvider1;
    }
}