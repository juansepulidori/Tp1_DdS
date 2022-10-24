using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ecommerce_Comentarios
{
    internal class Producto
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public List<Comentario> comentarios = new List<Comentario>();

        public string PromedioCalificaciones(SqlConnection connection, int fk_idProducto)
        {
            try
            {
                SqlCommand selectPromedio = new SqlCommand($"select avg(calificacion) from Comentarios where fk_IdProducto = {fk_idProducto} ", connection);
                selectPromedio.ExecuteNonQuery();
                SqlDataReader lector = selectPromedio.ExecuteReader();
                lector.Read();
                double promedio = lector.GetDouble(0);
                promedio = Math.Round(promedio, 1);
                return promedio.ToString();
            }
            catch (Exception ex)
            {
                return "0";
            }
        }
    }
}
