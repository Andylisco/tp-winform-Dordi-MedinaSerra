using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace Carrito_Web
{
    public partial class ArticuloForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txt_Codigo.MaxLength = 3;
                txt_Nombre.MaxLength = 50;
                CargarCombos();
            }
            
           


        }

        private void CargarCombos()
        {
            CargaCategorias();
            CargaMarcas();
            
        }

        private void CargaCategorias()
        {
            CategoriaNegocio CatNeg = new CategoriaNegocio();
            cbx_Categoria.DataSource = CatNeg.listar();
            cbx_Categoria.DataValueField = "Id";
            cbx_Categoria.DataTextField = "Descripcion";
            cbx_Categoria.DataBind();
        }

        private void CargaMarcas()
        {
            MarcaNegocio MarcaNeg = new MarcaNegocio();
            cbx_Marca.DataSource = MarcaNeg.listar();
            cbx_Marca.DataValueField = "Id";
            cbx_Marca.DataTextField = "Descripcion";
            cbx_Marca.DataBind();
            
        }



    }
}