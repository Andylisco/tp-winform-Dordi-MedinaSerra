using GestorArchivos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace GestorArchivos.Clases
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
                //SE IMPLEMENTO LA RUTA DE CONECCION EN EL App.config SE LLAMA A LA MISMA USANDO CONFIGURATIONMANGER Y EL NOMBRE
                ConnectionStringSettings Configuracion = ConfigurationManager.ConnectionStrings["CS"];
                conexion.ConnectionString = (string)Configuracion.ConnectionString;
                //
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id,Descripcion  From CATEGORIAS ORDER BY Id ASC";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Categoria aux = new Categoria();

                    aux.id = (int)lector["ID"];
                    aux.Descripcion = (string)lector["Descripcion"];

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