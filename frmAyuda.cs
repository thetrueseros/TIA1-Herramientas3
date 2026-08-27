using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIA1
{
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
            WebBrowser navegador = new WebBrowser();
            navegador.Dock = DockStyle.Fill; // Ocupa toda la ventana
            navegador.ScriptErrorsSuppressed = true;

            this.Controls.Add(navegador); // Agregarlo al formulario

            // Navegar a la página
            navegador.Navigate("https://github.com/thetrueseros/TIA1-Herramientas3");
        }
    }
}
