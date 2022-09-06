using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Diseño
{
    internal class ValidarComentario
    {
        public bool ComentarioCompleto(int calificacion, string opinion)
        {
            if (calificacion != 0 && opinion != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
