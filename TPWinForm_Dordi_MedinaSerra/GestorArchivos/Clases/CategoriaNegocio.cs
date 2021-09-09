using GestorArchivos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestorArchivos
{
    class CategoriaNegocio
    {


        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLESPRESS0; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id,Descripcion  From CATEGORIAS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Categoria aux = new Categoria();

                    aux.id = lector.GetInt32(0);
                    aux.Descripcion = lector.GetString(3);

                    lista.Add(aux);
                }

                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }




        }

    }
}