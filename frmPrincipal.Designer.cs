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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, tablasToolStripMenuItem, facturaciónToolStripMenuItem, seguridadToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // tablasToolStripMenuItem
            // 
            tablasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formularioClientesToolStripMenuItem, formularioProductosToolStripMenuItem, formularioCategoriasToolStripMenuItem });
            tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            tablasToolStripMenuItem.Size = new Size(51, 20);
            tablasToolStripMenuItem.Text = "Tablas";
            tablasToolStripMenuItem.Click += tablasToolStripMenuItem_Click;
            // 
            // formularioClientesToolStripMenuItem
            // 
            formularioClientesToolStripMenuItem.Name = "formularioClientesToolStripMenuItem";
            formularioClientesToolStripMenuItem.Size = new Size(130, 22);
            formularioClientesToolStripMenuItem.Text = "Clientes";
            // 
            // formularioProductosToolStripMenuItem
            // 
            formularioProductosToolStripMenuItem.Name = "formularioProductosToolStripMenuItem";
            formularioProductosToolStripMenuItem.Size = new Size(130, 22);
            formularioProductosToolStripMenuItem.Text = "Productos";
            // 
            // formularioCategoriasToolStripMenuItem
            // 
            formularioCategoriasToolStripMenuItem.Name = "formularioCategoriasToolStripMenuItem";
            formularioCategoriasToolStripMenuItem.Size = new Size(130, 22);
            formularioCategoriasToolStripMenuItem.Text = "Categorias";
            // 
            // facturaciónToolStripMenuItem
            // 
            facturaciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formularioFacturasToolStripMenuItem, formularioInformesToolStripMenuItem });
            facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            facturaciónToolStripMenuItem.Size = new Size(81, 20);
            facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // formularioFacturasToolStripMenuItem
            // 
            formularioFacturasToolStripMenuItem.Name = "formularioFacturasToolStripMenuItem";
            formularioFacturasToolStripMenuItem.Size = new Size(121, 22);
            formularioFacturasToolStripMenuItem.Text = "Facturas";
            // 
            // formularioInformesToolStripMenuItem
            // 
            formularioInformesToolStripMenuItem.Name = "formularioInformesToolStripMenuItem";
            formularioInformesToolStripMenuItem.Size = new Size(121, 22);
            formularioInformesToolStripMenuItem.Text = "Informes";
            // 
            // seguridadToolStripMenuItem
            // 
            seguridadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formularioEmpleadosToolStripMenuItem, formularioRolesToolStripMenuItem, formularioSeguridadToolStripMenuItem });
            seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            seguridadToolStripMenuItem.Size = new Size(72, 20);
            seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // formularioEmpleadosToolStripMenuItem
            // 
            formularioEmpleadosToolStripMenuItem.Name = "formularioEmpleadosToolStripMenuItem";
            formularioEmpleadosToolStripMenuItem.Size = new Size(132, 22);
            formularioEmpleadosToolStripMenuItem.Text = "Empleados";
            formularioEmpleadosToolStripMenuItem.Click += formularioEmpleadosToolStripMenuItem_Click;
            // 
            // formularioRolesToolStripMenuItem
            // 
            formularioRolesToolStripMenuItem.Name = "formularioRolesToolStripMenuItem";
            formularioRolesToolStripMenuItem.Size = new Size(132, 22);
            formularioRolesToolStripMenuItem.Text = "Roles";
            // 
            // formularioSeguridadToolStripMenuItem
            // 
            formularioSeguridadToolStripMenuItem.Name = "formularioSeguridadToolStripMenuItem";
            formularioSeguridadToolStripMenuItem.Size = new Size(132, 22);
            formularioSeguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ayudaToolStripMenuItem1, acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaToolStripMenuItem1
            // 
            ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            ayudaToolStripMenuItem1.Size = new Size(180, 22);
            ayudaToolStripMenuItem1.Text = "Ayuda";
            ayudaToolStripMenuItem1.Click += ayudaToolStripMenuItem1_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(180, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
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
    }
}
