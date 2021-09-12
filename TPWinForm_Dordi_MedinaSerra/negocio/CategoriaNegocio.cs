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
    public class CategoriaNegocio
    {
       
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id,Descripcion  From CATEGORIAS ORDER BY Id ASC");
                datos.ejecutarLectura();
               
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();

                    aux.id = (int)datos.Lector["ID"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

              return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        

    }
}
