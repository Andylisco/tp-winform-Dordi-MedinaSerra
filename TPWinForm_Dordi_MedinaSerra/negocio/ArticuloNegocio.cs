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
        public Articulo listar(int NroID)
        {
            AccesoDatos Datos = new AccesoDatos();

            Datos.setearConsulta("SELECT Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio FROM ARTICULOS WHERE id = @ID");
            Datos.setearParametros("@ID", NroID);

            Datos.ejecutarLectura();

            Articulo Art = new Articulo();

            while (Datos.Lector.Read())
            {
                Art.id = (int)Datos.Lector["Id"];
                if(!(Datos.Lector["Codigo"] is DBNull))
                Art.Codigo = (string)Datos.Lector["Codigo"];
                if (!(Datos.Lector["Nombre"] is DBNull))
                    Art.Nombre = (string)Datos.Lector["Nombre"];
                if (!(Datos.Lector["Descripcion"] is DBNull))
                    Art.Descripcion = (string)Datos.Lector["Descripcion"];

                Art.Marca = new Marca();
                if (!(Datos.Lector["IdMarca"] is DBNull))
                    Art.Marca.id = (int)Datos.Lector["IdMarca"];
               
                Art.Categoria = new Categoria();
                if (!(Datos.Lector["IdCategoria"] is DBNull))
                    Art.Categoria.id = (int)Datos.Lector["IdCategoria"];
                Art.Categoria.Descripcion = "";

                if (!(Datos.Lector["ImagenURL"] is DBNull))
                    Art.URLImagen = (string)Datos.Lector["ImagenURL"];
                if (!(Datos.Lector["Precio"] is DBNull))
                    Art.Precio = (decimal)Datos.Lector["Precio"];
            }   

           

            return Art;
        }
        public List<Articulo> listarArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();


            try
            {

                //datos.setearConsulta("SELECT id, Codigo = ISNULL(Codigo,''),Nombre = ISNULL(Nombre,''), Descripcion = ISNULL(Descripcion,''), IdMarca = ISNULL(IdMarca,0), IdCategoria = ISNULL(IdCategoria,0), ImagenURL = ISNULL(ImagenUrl,''), Precio = ISNULL(Precio,0.0) FROM ARTICULOSMarca");
                datos.setearConsulta("SELECT Ar.id, Codigo = ISNULL(Ar.Codigo,''),Nombre = ISNULL(Ar.Nombre,'')" +
                                     ", Descripcion = ISNULL(Ar.Descripcion, ''), IdMarca = ISNULL(Ar.IdMarca, 0)," +
                                     " IdCategoria = ISNULL(Ar.IdCategoria, 0), ImagenURL = ISNULL(Ar.ImagenUrl, ''), " +
                                     "Precio = ISNULL(Ar.Precio, 0.0), Cate_Des = ISNULL(Ca.Descripcion,''), Mar_Des = ISNULL(Ma.Descripcion,'') " +
                                     "FROM ARTICULOS Ar INNER JOIN CATEGORIAS Ca on ar.IdCategoria = Ca.Id " +
                                     "INNER JOIN MARCAS Ma ON Ar.IdMarca = Ma.Id");

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
                    aux.Marca.Descripcion = (string)datos.Lector["Mar_Des"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Cate_Des"];
                    
                   
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

            datos.setearConsulta("INSERT INTO ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio)" +
                                "values( @Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @URLimagen, @Precio)");

            datos.setearParametros("@Codigo", nuevo.Codigo );
            datos.setearParametros("@Nombre", nuevo.Nombre );
            datos.setearParametros("@Descripcion", nuevo.Descripcion);
            datos.setearParametros("@IdMarca", nuevo.Marca.id );
            datos.setearParametros("@IdCategoria", nuevo.Categoria.id );
            datos.setearParametros("@URLimagen", nuevo.URLImagen );
            datos.setearParametros("@Precio", nuevo.Precio.ToString().Replace(",","."));
            datos.ejecutarAccion();    
            
            datos.cerrarConexion();
            
        }

        public void Actualizar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

        
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, " +
                    "IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @URLimagen, Precio = @Precio WHERE Id = @ID");

                datos.setearParametros("@Codigo",nuevo.Codigo);
                datos.setearParametros("@Nombre",nuevo.Nombre);
                datos.setearParametros("@Descripcion",nuevo.Descripcion);
                datos.setearParametros("@IdMarca",nuevo.Marca.id);
                datos.setearParametros("@IdCategoria",nuevo.Categoria.id);
                datos.setearParametros("@URLimagen", nuevo.URLImagen);
                datos.setearParametros("@Precio",nuevo.Precio.ToString().Replace(",", "."));
                datos.setearParametros("@ID",nuevo.id );
                datos.ejecutarAccion();
            
                datos.cerrarConexion();
            
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
