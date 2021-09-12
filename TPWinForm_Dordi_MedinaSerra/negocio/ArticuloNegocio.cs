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
        public  List<Articulo> listarArticulos()
        {
            return  listarArticulos("");  
        }
        public List<Articulo> listarArticulos(string Consulta)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearConsulta("SELECT id, Codigo = ISNULL(Codigo,''),Nombre = ISNULL(Nombre,''), Descripcion = ISNULL(Descripcion,''), IdMarca = ISNULL(IdMarca,0), IdCategoria = ISNULL(IdCategoria,0), ImagenURL = ISNULL(ImagenUrl,''), Precio = ISNULL(Precio,0.0) FROM ARTICULOS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    //Modifique como recibimos los datos para facilitar la lectura de los mismos
                    aux.id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    
                    
                    //SE CARGA LAS PROPIEDADES MARCA Y CATEGORIA COMO OBJETOS
                    aux.Marca = new Marca();
                    aux.Marca.id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = "";

                    aux.Categoria = new Categoria();
                    aux.Categoria.id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = "";
                    
                   
                    aux.URLImagen = (string)datos.Lector["ImagenURL"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                datos.cerrarConexion();
            }

           
            
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio)values( "+ nuevo.Codigo + ", '" + nuevo.Nombre + ", '" + nuevo.Descripcion + ", '" + nuevo.Marca.id + ", '" + nuevo.Categoria.id + ", '" + nuevo.URLImagen + ", '" + nuevo.Precio +")");
                datos.ejecutarAccion();    
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void BorrarArt(int ID)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("DELETE FROM Articulos WHERE Id = " + ID + "");
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
