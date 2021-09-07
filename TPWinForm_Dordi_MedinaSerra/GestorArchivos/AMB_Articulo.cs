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
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT Descripcion FROM Categorias ORDER BY Id";
            comando.Connection = conexion;

            
            cbx_Categoria.Items.Add("");
            

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    cbx_Categoria.Items.Add(lector["Descripcion"]);
                }

                conexion.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar a base Categorias");
            }

        }
        private void CargaMarcas()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT Descripcion FROM Marcas ORDER BY Id";
            comando.Connection = conexion;


            cbx_Marca.Items.Add("");


            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    cbx_Marca.Items.Add(lector["Descripcion"]);
                }

                conexion.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar a base Marcas");
            }

        }

    }
}
