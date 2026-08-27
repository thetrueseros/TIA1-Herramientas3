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
            lblAdminUsuariosSistema = new Label();
            lblEmpleado = new Label();
            lblUsuario = new Label();
            lblContraseña = new Label();
            cmbEmpleado = new ComboBox();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnActualizar = new Button();
            btnSalir = new Button();
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
            lblEmpleado.Location = new Point(73, 107);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(60, 15);
            lblEmpleado.TabIndex = 1;
            lblEmpleado.Text = "Empleado";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(73, 155);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(73, 204);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
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
            btnActualizar.Location = new Point(219, 273);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(510, 276);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmAdminSeguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "frmAdminSeguridad";
            Text = "ADMINISTRACIÓN DE USUARIOS DEL SISTEMA";
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
    }
}