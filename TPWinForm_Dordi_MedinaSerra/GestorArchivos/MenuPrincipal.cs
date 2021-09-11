using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestorArchivos
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        
        private void crearNuevoArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AMB_Articulo().Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buscarPorCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListadoArticulos().Show();

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
