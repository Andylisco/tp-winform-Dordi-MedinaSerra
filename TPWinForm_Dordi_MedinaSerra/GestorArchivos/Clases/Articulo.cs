using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorArchivos
{
    class Articulo
    {
        public int id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Categoria { get; set; }
        public int Marcar { get; set; }
        public string URLImagen{ get; set; }
        public decimal Precio { get; set; }

    }
}
