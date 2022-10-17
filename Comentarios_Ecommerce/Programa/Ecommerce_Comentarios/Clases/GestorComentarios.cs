using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using System.Data;
using System.Data.SqlClient;

namespace Ecommerce_Comentarios
{
    internal class GestorComentarios
    {
        public SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Program.direccionDataBase+";Integrated Security=True");
        public List<String> ErroresComentario()
        {
            var validaciones = new ValidacionesComentario();
            var validacion = validaciones.Validate(Program.comentario);
            List<String> errores = new List<String>();
            if (validacion.IsValid)
            {
                return null;
            }
            else
            {
                foreach (var error in validacion.Errors)
                {
                    errores.Add(error.PropertyName);
                    errores.Add(error.ErrorMessage);
                }
                return errores;
            }

        }
        public void GuardarComentario()
        {
            conexion.Open();
            SqlCommand insert = new SqlCommand($"insert into Comentarios values('{Program.comentario.opinion}', {Program.comentario.calificacion}, '{Program.comentario.fechaComentario}', 0, 0, {Program.comentario.fkProducto})", conexion);
            insert.ExecuteNonQuery();
            conexion.Close();
        }
        public DataTable Productos()
        {
            conexion.Open();
            SqlCommand selectProductos = new SqlCommand("select * from Producto", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(selectProductos);
            DataTable productos = new DataTable();
            adapter.Fill(productos);
            conexion.Close();
            return productos;
        }
    }
}
