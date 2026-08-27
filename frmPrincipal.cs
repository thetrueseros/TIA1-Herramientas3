namespace TIA1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
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
            empleados.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda();
            ayuda.MdiParent = this;
            ayuda.Show();

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercade acercade = new frmAcercade();
            acercade.MdiParent = this;
            acercade.Show();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formularioClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void formularioProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.MdiParent = this;
            productos.Show();
        }

        private void formularioCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoriaProductos categorias = new frmCategoriaProductos();
            categorias.MdiParent = this;
            categorias.Show();
        }

        private void formularioFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturas facturas = new frmFacturas();
            facturas.MdiParent = this;
            facturas.Show();
        }

        private void formularioInformesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformes informes = new frmInformes();
            informes.MdiParent = this;
            informes.Show();
        }

        private void formularioRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRolEmpleados roles = new frmRolEmpleados();
            roles.MdiParent = this;
            roles.Show();
        }

        private void formularioSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminSeguridad seguridad = new frmAdminSeguridad();
            seguridad.MdiParent = this;
            seguridad.Show();
        }
    }
}
