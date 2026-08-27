namespace TIA1
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            tablasToolStripMenuItem = new ToolStripMenuItem();
            formularioClientesToolStripMenuItem = new ToolStripMenuItem();
            formularioProductosToolStripMenuItem = new ToolStripMenuItem();
            formularioCategoriasToolStripMenuItem = new ToolStripMenuItem();
            facturaciónToolStripMenuItem = new ToolStripMenuItem();
            formularioFacturasToolStripMenuItem = new ToolStripMenuItem();
            formularioInformesToolStripMenuItem = new ToolStripMenuItem();
            seguridadToolStripMenuItem = new ToolStripMenuItem();
            formularioEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            formularioRolesToolStripMenuItem = new ToolStripMenuItem();
            formularioSeguridadToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem1 = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            panelContenedor = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(0, 0, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, tablasToolStripMenuItem, facturaciónToolStripMenuItem, seguridadToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.BackColor = Color.FromArgb(10, 10, 32);
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            archivoToolStripMenuItem.ForeColor = Color.White;
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(71, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.BackColor = Color.FromArgb(10, 10, 32);
            salirToolStripMenuItem.ForeColor = Color.White;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // tablasToolStripMenuItem
            // 
            tablasToolStripMenuItem.BackColor = Color.FromArgb(10, 10, 32);
            tablasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formularioClientesToolStripMenuItem, formularioProductosToolStripMenuItem, formularioCategoriasToolStripMenuItem });
            tablasToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            tablasToolStripMenuItem.ForeColor = Color.White;
            tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            tablasToolStripMenuItem.Size = new Size(62, 24);
            tablasToolStripMenuItem.Text = "Tablas";
            tablasToolStripMenuItem.Click += tablasToolStripMenuItem_Click;
            // 
            // formularioClientesToolStripMenuItem
            // 
            formularioClientesToolStripMenuItem.BackColor = Color.FromArgb(10, 10, 32);
            formularioClientesToolStripMenuItem.ForeColor = Color.White;
            formularioClientesToolStripMenuItem.Name = "formularioClientesToolStripMenuItem";
            formularioClientesToolStripMenuItem.Size = new Size(180, 24);
            formularioClientesToolStripMenuItem.Text = "Clientes";
            formularioClientesToolStripMenuItem.Click += formularioClientesToolStripMenuItem_Click;
            // 
            // formularioProductosToolStripMenuItem
            // 
            formularioProductosToolStripMenuItem.BackColor = Color.FromArgb(10, 10, 32);
            formularioProductosToolStripMenuItem.ForeColor = Color.White;
            formularioProductosToolStripMenuItem.Name = "formularioProductosToolStripMenuItem";
            formularioProductosToolStripMenuItem.Size = new Size(180, 24);
            formularioProductosToolStripMenuItem.Text = "Productos";
            formularioProductosToolStripMenuItem.Click += formularioProductosToolStripMenuItem_Click;
            // 
            // formularioCategoriasToolStripMenuItem
            // 
            formularioCategoriasToolStripMenuItem.BackColor = Color.FromArgb(10, 10, 32);
            formularioCategoriasToolStripMenuItem.ForeColor = Color.White;
            formularioCategoriasToolStripMenuItem.Name = "formularioCategoriasToolStripMenuItem";
            formularioCategoriasToolStripMenuItem.Size = new Size(180, 24);
            formularioCategoriasToolStripMenuItem.Text = "Categorias";
            formularioCategoriasToolStripMenuItem.Click += formularioCategoriasToolStripMenuItem_Click;
            // 
            // facturaciónToolStripMenuItem
            // 
            facturaciónToolStripMenuItem.BackColor = Color.FromArgb(10, 10, 32);
            facturaciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formularioFacturasToolStripMenuItem, formularioInformesToolStripMenuItem });
            facturaciónToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            facturaciónToolStripMenuItem.ForeColor = Color.White;
            facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            facturaciónToolStripMenuItem.Size = new Size(96, 24);
            facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // formularioFacturasToolStripMenuItem
            // 
            formularioFacturasToolStripMenuItem.BackColor = Color.FromArgb(10, 10, 32);
            formularioFacturasToolStripMenuItem.ForeColor = Color.White;
            formularioFacturasToolStripMenuItem.Name = "formularioFacturasToolStripMenuItem";
            formularioFacturasToolStripMenuItem.Size = new Size(180, 24);
            formularioFacturasToolStripMenuItem.Text = "Facturas";
            formularioFacturasToolStripMenuItem.Click += formularioFacturasToolStripMenuItem_Click;
            // 
            // formularioInformesToolStripMenuItem
            // 
            formularioInformesToolStripMenuItem.BackColor = Color.FromArgb(10, 10, 32);
            formularioInformesToolStripMenuItem.ForeColor = Color.White;
            formularioInformesToolStripMenuItem.Name = "formularioInformesToolStripMenuItem";
            formularioInformesToolStripMenuItem.Size = new Size(180, 24);
            formularioInformesToolStripMenuItem.Text = "Informes";
            formularioInformesToolStripMenuItem.Click += formularioInformesToolStripMenuItem_Click;
            // 
            // seguridadToolStripMenuItem
            // 
            seguridadToolStripMenuItem.BackColor = Color.FromArgb(10, 10, 32);
            seguridadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formularioEmpleadosToolStripMenuItem, formularioRolesToolStripMenuItem, formularioSeguridadToolStripMenuItem });
            seguridadToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            seguridadToolStripMenuItem.ForeColor = Color.White;
            seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            seguridadToolStripMenuItem.Size = new Size(89, 24);
            seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // formularioEmpleadosToolStripMenuItem
            // 
            formularioEmpleadosToolStripMenuItem.BackColor = Color.FromArgb(10, 10, 32);
            formularioEmpleadosToolStripMenuItem.ForeColor = Color.White;
            formularioEmpleadosToolStripMenuItem.Name = "formularioEmpleadosToolStripMenuItem";
            formularioEmpleadosToolStripMenuItem.Size = new Size(180, 24);
            formularioEmpleadosToolStripMenuItem.Text = "Empleados";
            formularioEmpleadosToolStripMenuItem.Click += formularioEmpleadosToolStripMenuItem_Click;
            // 
            // formularioRolesToolStripMenuItem
            // 
            formularioRolesToolStripMenuItem.BackColor = Color.FromArgb(10, 10, 32);
            formularioRolesToolStripMenuItem.ForeColor = Color.White;
            formularioRolesToolStripMenuItem.Name = "formularioRolesToolStripMenuItem";
            formularioRolesToolStripMenuItem.Size = new Size(180, 24);
            formularioRolesToolStripMenuItem.Text = "Roles";
            formularioRolesToolStripMenuItem.Click += formularioRolesToolStripMenuItem_Click;
            // 
            // formularioSeguridadToolStripMenuItem
            // 
            formularioSeguridadToolStripMenuItem.BackColor = Color.FromArgb(10, 10, 32);
            formularioSeguridadToolStripMenuItem.ForeColor = Color.White;
            formularioSeguridadToolStripMenuItem.Name = "formularioSeguridadToolStripMenuItem";
            formularioSeguridadToolStripMenuItem.Size = new Size(180, 24);
            formularioSeguridadToolStripMenuItem.Text = "Seguridad";
            formularioSeguridadToolStripMenuItem.Click += formularioSeguridadToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.BackColor = Color.FromArgb(10, 10, 32);
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ayudaToolStripMenuItem1, acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            ayudaToolStripMenuItem.ForeColor = Color.White;
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(63, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaToolStripMenuItem1
            // 
            ayudaToolStripMenuItem1.BackColor = Color.FromArgb(10, 10, 32);
            ayudaToolStripMenuItem1.ForeColor = Color.White;
            ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            ayudaToolStripMenuItem1.Size = new Size(180, 24);
            ayudaToolStripMenuItem1.Text = "Ayuda";
            ayudaToolStripMenuItem1.Click += ayudaToolStripMenuItem1_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.BackColor = Color.FromArgb(10, 10, 32);
            acercaDeToolStripMenuItem.ForeColor = Color.White;
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(180, 24);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.AutoSize = true;
            panelContenedor.BackColor = Color.FromArgb(0, 0, 64);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 28);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(800, 422);
            panelContenedor.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContenedor);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmPrincipal_FormClosing;
            FormClosed += frmPrincipal_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem tablasToolStripMenuItem;
        private ToolStripMenuItem formularioClientesToolStripMenuItem;
        private ToolStripMenuItem formularioProductosToolStripMenuItem;
        private ToolStripMenuItem facturaciónToolStripMenuItem;
        private ToolStripMenuItem seguridadToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem formularioCategoriasToolStripMenuItem;
        private ToolStripMenuItem formularioFacturasToolStripMenuItem;
        private ToolStripMenuItem formularioInformesToolStripMenuItem;
        private ToolStripMenuItem formularioEmpleadosToolStripMenuItem;
        private ToolStripMenuItem formularioRolesToolStripMenuItem;
        private ToolStripMenuItem formularioSeguridadToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem1;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Panel panelContenedor;
    }
}
