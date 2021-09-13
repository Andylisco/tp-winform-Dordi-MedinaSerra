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
using dominio;
using negocio;

namespace GestorArchivos
{
    public partial class AMB_Articulo : Form
    {
        public AMB_Articulo()
        {
            InitializeComponent();
        }

        private void AMB_Articulo_Load(object sender, EventArgs e)
        {
            CargaCombos();
        }

       private void CargaCombos()
        {
            CargaCategorias();
            CargaMarcas();

        }

        private void CargaCategorias()
        {
            try
            {
                CategoriaNegocio CatNeg = new CategoriaNegocio();
                cbx_Categoria.Items.Add("");

                foreach (Categoria Cate in CatNeg.listar())
                {
                    cbx_Categoria.Items.Add(Cate.Descripcion);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar las opciones de Categoría por problema de conexión", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
                  
        }
       
        private int idCategoria()
        {
            int a = new int();         
            try
            {
                
                CategoriaNegocio CatNeg = new CategoriaNegocio();
                
                foreach (Categoria Cate in CatNeg.listar())
                {
                    if (cbx_Categoria.SelectedText == Cate.Descripcion) a = Cate.id; 
                }

                return a;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private int idMarca()
        {
            int a = new int();
            try
            {
                CategoriaNegocio MarNeg = new CategoriaNegocio();
            
                foreach (Categoria Mar in MarNeg.listar())
                {
                    if (cbx_Categoria.SelectedText == Mar.Descripcion) a = Mar.id;
                    
                }

                
                return a;
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        private void CargaMarcas()
        {
            try
            {
                MarcaNegocio MarcaNeg = new MarcaNegocio();
                cbx_Marca.Items.Add("");

                foreach (Marca Mar in MarcaNeg.listar())
                {
                    cbx_Marca.Items.Add(Mar.Descripcion);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar las opciones de Marca por problema de conexión", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        
        }

        

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                
                nuevo.Codigo = txt_Codigo.Text;
                nuevo.Nombre = txt_Nombre.Text;
                nuevo.Descripcion = txt_Descripcion.Text;
                nuevo.Categoria = new Categoria();
                nuevo.Categoria.id = cbx_Marca.SelectedIndex;
                nuevo.Marca = new Marca();
                nuevo.Marca.id = cbx_Marca.SelectedIndex;
                nuevo.URLImagen = txt_URLImagen.Text;
                nuevo.Precio = decimal.Parse( txt_Precio.Text);

                negocio.agregar(nuevo);
                MessageBox.Show("Agregado exitosamente");
                Close();
    }           
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cbx_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }



    }
}
