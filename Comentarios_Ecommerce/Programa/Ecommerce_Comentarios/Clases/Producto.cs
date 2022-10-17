using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Comentarios
{
    internal class Producto
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public List<Comentario> comentarios = new List<Comentario>();
    }
}
