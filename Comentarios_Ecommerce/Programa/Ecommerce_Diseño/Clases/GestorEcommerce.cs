using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Diseño
{
    internal class GestorEcommerce
    {
        public void GestionarComentario(int calificacion, string opinion)
        {
            if(Program.validarComentario.ComentarioCompleto(calificacion, opinion))
            {
                Comentario comentario = new Comentario(calificacion, opinion, DateOnly.Parse("01/01/1901"), 0, 0);
                comentario.GuardarComentario();
            }
            else
            {
                MessageBox.Show("Faltan campos por completar");
            }
            
        }
    }
}
