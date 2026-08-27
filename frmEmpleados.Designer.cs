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
            SuspendLayout();
            // 
            // lblAdministracionEmpleados
            // 
            lblAdministracionEmpleados.AutoSize = true;
            lblAdministracionEmpleados.Font = new Font("Segoe UI", 24F);
            lblAdministracionEmpleados.Location = new Point(49, 9);
            lblAdministracionEmpleados.Name = "lblAdministracionEmpleados";
            lblAdministracionEmpleados.Size = new Size(518, 45);
            lblAdministracionEmpleados.TabIndex = 0;
            lblAdministracionEmpleados.Text = "ADMINISTRACIÓN DE EMPLEADOS";
            // 
            // lblNombreEmpleado
            // 
            lblNombreEmpleado.AutoSize = true;
            lblNombreEmpleado.Location = new Point(49, 84);
            lblNombreEmpleado.Name = "lblNombreEmpleado";
            lblNombreEmpleado.Size = new Size(107, 15);
            lblNombreEmpleado.TabIndex = 1;
            lblNombreEmpleado.Text = "Nombre Empleado";
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(162, 81);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(176, 23);
            txtNombreEmpleado.TabIndex = 2;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(162, 137);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(176, 23);
            txtDocumento.TabIndex = 4;
            txtDocumento.TextChanged += textBox2_TextChanged;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(49, 140);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 3;
            lblDocumento.Text = "Documento";
            lblDocumento.Click += this.label2_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(162, 250);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(176, 23);
            txtTelefono.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(49, 253);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Teléfono";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(162, 198);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(176, 23);
            txtDireccion.TabIndex = 6;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(49, 201);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 5;
            lblDireccion.Text = "Dirección";
            // 
            // txtDatosAdicionales
            // 
            txtDatosAdicionales.Location = new Point(359, 242);
            txtDatosAdicionales.Multiline = true;
            txtDatosAdicionales.Name = "txtDatosAdicionales";
            txtDatosAdicionales.Size = new Size(205, 89);
            txtDatosAdicionales.TabIndex = 12;
            // 
            // lblDatosAdicionales
            // 
            lblDatosAdicionales.AutoSize = true;
            lblDatosAdicionales.Location = new Point(359, 215);
            lblDatosAdicionales.Name = "lblDatosAdicionales";
            lblDatosAdicionales.Size = new Size(120, 15);
            lblDatosAdicionales.TabIndex = 11;
            lblDatosAdicionales.Text = "DATOS ADICIONALES";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(162, 308);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 23);
            txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(49, 311);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // lblRolEmpleado
            // 
            lblRolEmpleado.AutoSize = true;
            lblRolEmpleado.Location = new Point(359, 84);
            lblRolEmpleado.Name = "lblRolEmpleado";
            lblRolEmpleado.Size = new Size(80, 15);
            lblRolEmpleado.TabIndex = 13;
            lblRolEmpleado.Text = "Rol Empleado";
            // 
            // cmbRolEmpleado
            // 
            cmbRolEmpleado.FormattingEnabled = true;
            cmbRolEmpleado.Location = new Point(443, 81);
            cmbRolEmpleado.Name = "cmbRolEmpleado";
            cmbRolEmpleado.Size = new Size(121, 23);
            cmbRolEmpleado.TabIndex = 14;
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(359, 126);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(80, 15);
            lblFechaIngreso.TabIndex = 15;
            lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // lblFechaRetiro
            // 
            lblFechaRetiro.AutoSize = true;
            lblFechaRetiro.Location = new Point(359, 173);
            lblFechaRetiro.Name = "lblFechaRetiro";
            lblFechaRetiro.Size = new Size(72, 15);
            lblFechaRetiro.TabIndex = 16;
            lblFechaRetiro.Text = "Fecha Retiro";
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Format = DateTimePickerFormat.Short;
            dtpFechaIngreso.Location = new Point(443, 120);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(121, 23);
            dtpFechaIngreso.TabIndex = 17;
            // 
            // dtpFechaRetiro
            // 
            dtpFechaRetiro.Format = DateTimePickerFormat.Short;
            dtpFechaRetiro.Location = new Point(443, 167);
            dtpFechaRetiro.Name = "dtpFechaRetiro";
            dtpFechaRetiro.Size = new Size(121, 23);
            dtpFechaRetiro.TabIndex = 18;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(151, 364);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(379, 364);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}