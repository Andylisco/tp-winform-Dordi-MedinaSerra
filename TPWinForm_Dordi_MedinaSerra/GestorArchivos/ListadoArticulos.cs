using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.DataGridView;
using dominio;
using negocio;

namespace GestorArchivos
{
    public partial class ListadoArticulos : Form
    {
        List<Articulo> LISTAGLOBAL = new List<Articulo>();
        public ListadoArticulos()
        {
            InitializeComponent();
        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
            dgv_Articulos.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dgv_Articulos.DefaultCellStyle.SelectionForeColor = Color.White;
            CargarGrilla();
        }
        
        private void CargarGrilla()
        {
            List<Articulo> lista = new List<Articulo>();
            ArticuloNegocio ArtNeg = new ArticuloNegocio();

            try
            {
                lista = ArtNeg.listarArticulos();
                LISTAGLOBAL = lista;
                dgv_Articulos.DataSource = lista;

                txt_Filtro.Text = "";
                        
            }
            catch (Exception )
            {
                MessageBox.Show("Error al cargar datos en la grilla.", "Conexion Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Filtro_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Filtro.Text == "")
            {
                dgv_Articulos.DataSource = LISTAGLOBAL;
                return;
            }
            List<Articulo> ListaFiltra = LISTAGLOBAL;
            //ListaFiltra = ListaFiltra.Where(x => x.id == int.Parse(txt_Filtro.Text)).ToList();
            ListaFiltra = ListaFiltra.Where(x =>  (x.Codigo.ToUpper().Contains(txt_Filtro.Text.Trim().ToUpper())) 
                                            | (x.Descripcion.ToUpper().Contains(txt_Filtro.Text.Trim().ToUpper()))
                                            | (x.Nombre.ToUpper().Contains(txt_Filtro.Text.Trim().ToUpper()))
                                            | (x.Precio.ToString().Contains(txt_Filtro.Text.Trim()))
                                            | (x.Categoria.Descripcion.ToUpper().Contains(txt_Filtro.Text.Trim().ToUpper()))
                                            | (x.Marca.Descripcion.ToUpper().Contains(txt_Filtro.Text.Trim().ToUpper()))
                                            ).ToList();
            dgv_Articulos.DataSource = ListaFiltra;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_Articulos_SelectionChanged(object sender, EventArgs e)
        {
            string URLImangen = (string)dgv_Articulos.CurrentRow.Cells["URLImagen"].Value;
            cargarImagen(URLImangen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbx_Seleccion_dgv.Load(imagen);
            }
            catch (Exception )
            {
                pbx_Seleccion_dgv.Load("https://dam.muyinteresante.com.mx/wp-content/uploads/2020/04/error-404.jpg");
            }
        }

        private void dgv_Articulos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_Articulos.CurrentRow.Selected = true;
        }

        private void dgv_Articulos_KeyDown(object sender, KeyEventArgs e)
        {
            dgv_Articulos.CurrentRow.Selected = true;
        }

        private void dgv_Articulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgv_Articulos.CurrentRow.Selected = true;
        }

        private void BORRARARTICULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea borrar el Articulo ID: " + dgv_Articulos.CurrentRow.Cells["id"].Value +
                             " " + dgv_Articulos.CurrentRow.Cells["Descripcion"].Value + "?", "Confirmar Baja Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ArticuloNegocio NegArt = new ArticuloNegocio();
                    NegArt.BorrarArt((int)dgv_Articulos.CurrentRow.Cells["id"].Value);
                    CargarGrilla();
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al intentar borrar un registro.", "Conexion Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }

        private void btn_NuevoArticulo_Click(object sender, EventArgs e)
        {
            AMB_Articulo alta = new AMB_Articulo();
            alta.ShowDialog();
            CargarGrilla();
        }


        private void dgv_Articulos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                btnModificar_Click(null, null);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgv_Articulos.CurrentRow.DataBoundItem;

            AMB_Articulo modificar = new AMB_Articulo(seleccionado);
            modificar.ShowDialog();
            CargarGrilla();
        }

        private void mODIFICARARTICULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnModificar_Click(null, null);
        }
    }
}
