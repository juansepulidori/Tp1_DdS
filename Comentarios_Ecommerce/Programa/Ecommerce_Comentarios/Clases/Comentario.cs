using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Comentarios { 
    internal class Comentario
    {
        public int calificacion { get; set; }
        public string opinion { get; set; }
        public DateTime fechaComentario { get; set; }
        public int fkProducto { get; set; }


    }
}
