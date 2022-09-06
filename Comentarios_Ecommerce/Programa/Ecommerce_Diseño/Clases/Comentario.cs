using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Diseño
{
    internal class Comentario
    {
        private int calificacion;
        private string opinion;
        private DateOnly fecha;
        private int meGusta;
        private int noMegusta;

        public Comentario(int calificacion, string opinion, DateOnly fecha, int meGusta, int noMegusta)
        {
            this.calificacion = calificacion;
            this.opinion = opinion;
            this.fecha = fecha;
            this.meGusta = meGusta;
            this.noMegusta = noMegusta;
        }

        public void GuardarComentario()
        {
            MessageBox.Show("Su comentario se guardó exitosamente");
        }
    }
}
