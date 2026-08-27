namespace TIA1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Mostrar mensaje de confirmación
            DialogResult resultado = MessageBox.Show("¿Seguro que deseas salir?", "Confirmar", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true; // Cancela el cierre del formulario
            }
        }



        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            // Si ya hay un control en el panel, se remueve
            if (this.panelContenedor.Controls.Count > 0)
            {
                Form formularioAnterior = this.panelContenedor.Controls[0] as Form;
                if (formularioAnterior != null)
                {
                    formularioAnterior.Close();   // Cierra el formulario
                    formularioAnterior.Dispose(); // Libera la memoria RAM por completo
                }
                this.panelContenedor.Controls.Clear(); // Limpia el contenedor
            }

            formularioHijo.TopLevel = false; // El formulario deja de ser ventana independiente
            formularioHijo.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
            formularioHijo.Dock = DockStyle.Fill; // Rellena todo el panel

            this.panelContenedor.Controls.Add(formularioHijo);
            this.panelContenedor.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void tablasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void formularioEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados empleados = new frmEmpleados();
            empleados.MdiParent = this;
            AbrirFormularioEnPanel(empleados);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda();
            ayuda.MdiParent = this;
            AbrirFormularioEnPanel(ayuda);

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercade acercade = new frmAcercade();
            acercade.MdiParent = this;
            AbrirFormularioEnPanel(acercade);
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formularioClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.MdiParent = this;
            AbrirFormularioEnPanel(clientes);
        }

        private void formularioProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.MdiParent = this;
            AbrirFormularioEnPanel(productos);
        }

        private void formularioCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoriaProductos categorias = new frmCategoriaProductos();
            categorias.MdiParent = this;
            AbrirFormularioEnPanel(categorias);
        }

        private void formularioFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturas facturas = new frmFacturas();
            facturas.MdiParent = this;
            AbrirFormularioEnPanel(facturas);
        }

        private void formularioInformesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformes informes = new frmInformes();
            informes.MdiParent = this;
            AbrirFormularioEnPanel(informes);
        }

        private void formularioRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRolEmpleados roles = new frmRolEmpleados();
            roles.MdiParent = this;
            AbrirFormularioEnPanel(roles);
        }

        private void formularioSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminSeguridad seguridad = new frmAdminSeguridad();
            seguridad.MdiParent = this;
            AbrirFormularioEnPanel(seguridad);
        }
    }
}
