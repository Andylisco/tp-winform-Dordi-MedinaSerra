using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using dominio;



namespace negocio
{
    public class MarcaNegocio
    {

        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
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
                comando.CommandText = "SELECT Id,Descripcion  From CATEGORIAS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Marca aux = new Marca();

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
