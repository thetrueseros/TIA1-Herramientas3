namespace TIA1
{
    partial class frmCategoriaProductos
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
            btnActualizar = new Button();
            btnSalir = new Button();
            lblCategoriaProductos = new Label();
            lblNombreCategoria = new Label();
            txtNombreCategoria = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Highlight;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 11F);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(97, 210);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(96, 30);
            btnActualizar.TabIndex = 0;
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
            btnSalir.Location = new Point(280, 210);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(96, 30);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblCategoriaProductos
            // 
            lblCategoriaProductos.AutoSize = true;
            lblCategoriaProductos.Font = new Font("Segoe UI", 24F);
            lblCategoriaProductos.ForeColor = Color.White;
            lblCategoriaProductos.Location = new Point(59, 20);
            lblCategoriaProductos.Name = "lblCategoriaProductos";
            lblCategoriaProductos.Size = new Size(378, 45);
            lblCategoriaProductos.TabIndex = 2;
            lblCategoriaProductos.Text = "CATEGORÍA PRODUCTOS";
            // 
            // lblNombreCategoria
            // 
            lblNombreCategoria.AutoSize = true;
            lblNombreCategoria.Font = new Font("Segoe UI", 11F);
            lblNombreCategoria.ForeColor = Color.White;
            lblNombreCategoria.Location = new Point(85, 118);
            lblNombreCategoria.Name = "lblNombreCategoria";
            lblNombreCategoria.Size = new Size(133, 20);
            lblNombreCategoria.TabIndex = 3;
            lblNombreCategoria.Text = "Nombre Categoría";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(224, 119);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(158, 23);
            txtNombreCategoria.TabIndex = 4;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmCategoriaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(495, 305);
            Controls.Add(txtNombreCategoria);
            Controls.Add(lblNombreCategoria);
            Controls.Add(lblCategoriaProductos);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Name = "frmCategoriaProductos";
            Text = "Categoría Productos";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private Button btnSalir;
        private Label lblCategoriaProductos;
        private Label lblNombreCategoria;
        private TextBox txtNombreCategoria;
        private ErrorProvider errorProvider1;
    }
}