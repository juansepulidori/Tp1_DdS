using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ecommerce_Comentarios { 
    internal class Comentario
    {
        public int calificacion { get; set; }
        public string opinion { get; set; }
        public DateTime fechaComentario { get; set; }
        public int fkProducto { get; set; }

        public void Guardar(SqlConnection conexion)
        {
            SqlCommand insert = new SqlCommand($"insert into Comentarios values('{Program.comentario.opinion}', {Program.comentario.calificacion}, '{Program.comentario.fechaComentario}', 0, 0, {Program.comentario.fkProducto})", conexion);
            insert.ExecuteNonQuery();
        }


    }
}
