using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace Carrito_Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio ArtNeg = new ArticuloNegocio();

            List<Articulo> ListaArt = ArtNeg.listarArticulos();

            dgvArticulos.DataSource = ListaArt;

            dgvArticulos.DataBind();

        }

       
    }
}