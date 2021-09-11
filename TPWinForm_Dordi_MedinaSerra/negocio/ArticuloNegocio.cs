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
    
    public class ArticuloNegocio
    {
        public  List<Articulo> listar()
        {
            return  listar("");
            
        }
        public List<Articulo> listar(string Consulta)
        {
            List<Articulo> lista = new List<Articulo>();
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

                if (Consulta == "")
                {
                    comando.CommandText = "SELECT id, Codigo = ISNULL(Codigo,''),Nombre = ISNULL(Nombre,''), Descripcion = ISNULL(Descripcion,''), IdMarca = ISNULL(IdMarca,0), IdCategoria = ISNULL(IdCategoria,0), ImagenURL = ISNULL(ImagenUrl,''), Precio = ISNULL(Precio,0.0) FROM ARTICULOS"; 
                }
                else
                { 
                    comando.CommandText = Consulta;
                }
                
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    //Modifique como recibimos los datos para facilitar la lectura de los mismos
                    aux.id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    //SE CARGA LAS PROPIEDADES MARCA Y CATEGORIA COMO OBJETOS
                    aux.Marca = new Marca();
                    aux.Marca.id = (int)lector["IdMarca"];
                    aux.Marca.Descripcion = "";

                    aux.Categoria = new Categoria();
                    aux.Categoria.id = (int)lector["IdCategoria"];
                    aux.Categoria.Descripcion = "";
                    
                    //
                    aux.URLImagen = (string)lector["ImagenURL"];
                    aux.Precio = (decimal)lector["Precio"];

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

        public void BorrarArt(int ID)
        {
            SqlConnection Conexion = new SqlConnection();
            SqlCommand Comando = new SqlCommand();
            
            ConnectionStringSettings CS = ConfigurationManager.ConnectionStrings["CS"];
            Conexion.ConnectionString = (string)CS.ConnectionString;
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = "DELETE FROM Articulos WHERE Id = " + ID + "";

            Comando.Connection = Conexion;

            try
            {
                Conexion.Open();
                               

                if (Comando.ExecuteNonQuery() == 1)
                    MessageBox.Show("Se elimino correctamente el registro", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrio un error al querer eliminar el registro","Aviso del Sistema", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            

        }

    }
}
