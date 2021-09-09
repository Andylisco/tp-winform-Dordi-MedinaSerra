using GestorArchivos.Clases;
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

        //SE VOLVIO A IMPLEMENTAR EL CARGACOMBOS
        //AHORA UTILIZANDO LAS CLASES CREADAS
        private void CargaCombos()
        {
            CargaCategorias();
            CargaMarcas();

        }

        private void CargaCategorias()
        {
                     
            CategoriaNegocio CatNeg = new CategoriaNegocio();

            cbx_Categoria.Items.Add("");
            try
            {
                //RECORREMOS La LISTA QUE NOS DA LISTAR PARA AGREGAR LOS ITEMS AL COMBOBOX
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

        private void CargaMarcas()
        {

        MarcaNegocio MarcaNeg = new MarcaNegocio();

        cbx_Marca.Items.Add("");

            try
            {
                //RECORREMOS La LISTA QUE NOS DA LISTAR PARA AGREGAR LOS ITEMS AL COMBOBOX
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


        
    }
}
