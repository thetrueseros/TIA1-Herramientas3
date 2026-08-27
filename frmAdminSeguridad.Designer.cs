namespace TIA1
{
    partial class frmAdminSeguridad
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
            lblAdminUsuariosSistema = new Label();
            lblEmpleado = new Label();
            lblUsuario = new Label();
            lblContraseña = new Label();
            cmbEmpleado = new ComboBox();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnActualizar = new Button();
            btnSalir = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblAdminUsuariosSistema
            // 
            lblAdminUsuariosSistema.AutoSize = true;
            lblAdminUsuariosSistema.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminUsuariosSistema.ForeColor = Color.Red;
            lblAdminUsuariosSistema.Location = new Point(37, 9);
            lblAdminUsuariosSistema.Name = "lblAdminUsuariosSistema";
            lblAdminUsuariosSistema.Size = new Size(732, 45);
            lblAdminUsuariosSistema.TabIndex = 0;
            lblAdminUsuariosSistema.Text = "ADMINISTRACIÓN DE USUARIOS DEL SISTEMA";
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.BackColor = Color.FromArgb(0, 0, 64);
            lblEmpleado.Font = new Font("Segoe UI", 11F);
            lblEmpleado.ForeColor = SystemColors.ButtonFace;
            lblEmpleado.Location = new Point(58, 104);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(77, 20);
            lblEmpleado.TabIndex = 1;
            lblEmpleado.Text = "Empleado";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(0, 0, 64);
            lblUsuario.Font = new Font("Segoe UI", 11F);
            lblUsuario.ForeColor = SystemColors.ButtonFace;
            lblUsuario.Location = new Point(58, 152);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = Color.FromArgb(0, 0, 64);
            lblContraseña.Font = new Font("Segoe UI", 11F);
            lblContraseña.ForeColor = SystemColors.ButtonFace;
            lblContraseña.Location = new Point(58, 201);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña";
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(147, 104);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(581, 23);
            cmbEmpleado.TabIndex = 4;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(147, 152);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(581, 23);
            txtUsuario.TabIndex = 5;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(147, 201);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(581, 23);
            txtContrasena.TabIndex = 6;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Highlight;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 11F);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(219, 273);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(101, 26);
            btnActualizar.TabIndex = 7;
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
            btnSalir.Location = new Point(510, 273);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 26);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAdminSeguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(800, 339);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(cmbEmpleado);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(lblEmpleado);
            Controls.Add(lblAdminUsuariosSistema);
            Cursor = Cursors.Hand;
            Name = "frmAdminSeguridad";
            Text = "ADMINISTRACIÓN DE USUARIOS DEL SISTEMA";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdminUsuariosSistema;
        private Label lblEmpleado;
        private Label lblUsuario;
        private Label lblContraseña;
        private ComboBox cmbEmpleado;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnActualizar;
        private Button btnSalir;
        private ErrorProvider errorProvider1;
    }
}