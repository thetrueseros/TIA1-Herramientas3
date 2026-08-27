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
            components = new System.ComponentModel.Container();
            lblRolEmpleados = new Label();
            lblNombreRol = new Label();
            lblDescripcionRol = new Label();
            txtNombreRol = new TextBox();
            txtDescripcionRol = new TextBox();
            btnActualizar = new Button();
            btnSalir = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblRolEmpleados
            // 
            lblRolEmpleados.AutoSize = true;
            lblRolEmpleados.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRolEmpleados.Location = new Point(47, 32);
            lblRolEmpleados.Name = "lblRolEmpleados";
            lblRolEmpleados.Size = new Size(330, 45);
            lblRolEmpleados.TabIndex = 0;
            lblRolEmpleados.Text = "ROL DE EMPLEADOS";
            // 
            // lblNombreRol
            // 
            lblNombreRol.AutoSize = true;
            lblNombreRol.Font = new Font("Segoe UI", 11F);
            lblNombreRol.ForeColor = Color.White;
            lblNombreRol.Location = new Point(71, 131);
            lblNombreRol.Name = "lblNombreRol";
            lblNombreRol.Size = new Size(90, 20);
            lblNombreRol.TabIndex = 1;
            lblNombreRol.Text = "Nombre Rol";
            // 
            // lblDescripcionRol
            // 
            lblDescripcionRol.AutoSize = true;
            lblDescripcionRol.Font = new Font("Segoe UI", 11F);
            lblDescripcionRol.ForeColor = Color.White;
            lblDescripcionRol.Location = new Point(73, 184);
            lblDescripcionRol.Name = "lblDescripcionRol";
            lblDescripcionRol.Size = new Size(201, 20);
            lblDescripcionRol.TabIndex = 2;
            lblDescripcionRol.Text = "Descripción detallada del rol";
            // 
            // txtNombreRol
            // 
            txtNombreRol.Location = new Point(182, 127);
            txtNombreRol.Margin = new Padding(3, 4, 3, 4);
            txtNombreRol.Name = "txtNombreRol";
            txtNombreRol.Size = new Size(172, 27);
            txtNombreRol.TabIndex = 3;
            // 
            // txtDescripcionRol
            // 
            txtDescripcionRol.Location = new Point(73, 220);
            txtDescripcionRol.Margin = new Padding(3, 4, 3, 4);
            txtDescripcionRol.Multiline = true;
            txtDescripcionRol.Name = "txtDescripcionRol";
            txtDescripcionRol.Size = new Size(281, 109);
            txtDescripcionRol.TabIndex = 4;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Highlight;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 11F);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(113, 375);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 31);
            btnActualizar.TabIndex = 5;
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
            btnSalir.Location = new Point(224, 375);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 31);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRolEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(435, 443);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(txtDescripcionRol);
            Controls.Add(txtNombreRol);
            Controls.Add(lblDescripcionRol);
            Controls.Add(lblNombreRol);
            Controls.Add(lblRolEmpleados);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.White;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRolEmpleados";
            Text = "Rol de Empleados";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private ErrorProvider errorProvider1;
    }
}