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
            btnActualizar = new Button();
            btnSalir = new Button();
            lblCategoriaProductos = new Label();
            lblNombreCategoria = new Label();
            txtNombreCategoria = new TextBox();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(97, 210);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 0;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(280, 210);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblCategoriaProductos
            // 
            lblCategoriaProductos.AutoSize = true;
            lblCategoriaProductos.Font = new Font("Segoe UI", 24F);
            lblCategoriaProductos.Location = new Point(43, 24);
            lblCategoriaProductos.Name = "lblCategoriaProductos";
            lblCategoriaProductos.Size = new Size(378, 45);
            lblCategoriaProductos.TabIndex = 2;
            lblCategoriaProductos.Text = "CATEGORÍA PRODUCTOS";
            // 
            // lblNombreCategoria
            // 
            lblNombreCategoria.AutoSize = true;
            lblNombreCategoria.Location = new Point(88, 122);
            lblNombreCategoria.Name = "lblNombreCategoria";
            lblNombreCategoria.Size = new Size(105, 15);
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
            // frmCategoriaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 305);
            Controls.Add(txtNombreCategoria);
            Controls.Add(lblNombreCategoria);
            Controls.Add(lblCategoriaProductos);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Name = "frmCategoriaProductos";
            Text = "Categoría Productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private Button btnSalir;
        private Label lblCategoriaProductos;
        private Label lblNombreCategoria;
        private TextBox txtNombreCategoria;
    }
}