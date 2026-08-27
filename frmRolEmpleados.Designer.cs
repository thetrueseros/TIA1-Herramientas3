namespace TIA1
{
    partial class frmRolEmpleados
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
            lblRolEmpleados = new Label();
            lblNombreRol = new Label();
            lblDescripcionRol = new Label();
            txtNombreRol = new TextBox();
            txtDescripcionRol = new TextBox();
            btnActualizar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblRolEmpleados
            // 
            lblRolEmpleados.AutoSize = true;
            lblRolEmpleados.Font = new Font("Segoe UI", 24F);
            lblRolEmpleados.Location = new Point(35, 24);
            lblRolEmpleados.Name = "lblRolEmpleados";
            lblRolEmpleados.Size = new Size(312, 45);
            lblRolEmpleados.TabIndex = 0;
            lblRolEmpleados.Text = "ROL DE EMPLEADOS";
            // 
            // lblNombreRol
            // 
            lblNombreRol.AutoSize = true;
            lblNombreRol.Location = new Point(62, 98);
            lblNombreRol.Name = "lblNombreRol";
            lblNombreRol.Size = new Size(71, 15);
            lblNombreRol.TabIndex = 1;
            lblNombreRol.Text = "Nombre Rol";
            // 
            // lblDescripcionRol
            // 
            lblDescripcionRol.AutoSize = true;
            lblDescripcionRol.Location = new Point(64, 138);
            lblDescripcionRol.Name = "lblDescripcionRol";
            lblDescripcionRol.Size = new Size(156, 15);
            lblDescripcionRol.TabIndex = 2;
            lblDescripcionRol.Text = "Descripción detallada del rol";
            // 
            // txtNombreRol
            // 
            txtNombreRol.Location = new Point(159, 95);
            txtNombreRol.Name = "txtNombreRol";
            txtNombreRol.Size = new Size(151, 23);
            txtNombreRol.TabIndex = 3;
            // 
            // txtDescripcionRol
            // 
            txtDescripcionRol.Location = new Point(64, 165);
            txtDescripcionRol.Multiline = true;
            txtDescripcionRol.Name = "txtDescripcionRol";
            txtDescripcionRol.Size = new Size(246, 83);
            txtDescripcionRol.TabIndex = 4;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(99, 281);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(196, 281);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmRolEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 332);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(txtDescripcionRol);
            Controls.Add(txtNombreRol);
            Controls.Add(lblDescripcionRol);
            Controls.Add(lblNombreRol);
            Controls.Add(lblRolEmpleados);
            Name = "frmRolEmpleados";
            Text = "Rol de Empleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRolEmpleados;
        private Label lblNombreRol;
        private Label lblDescripcionRol;
        private TextBox txtNombreRol;
        private TextBox txtDescripcionRol;
        private Button btnActualizar;
        private Button btnSalir;
    }
}