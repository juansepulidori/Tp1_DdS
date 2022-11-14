using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Newtonsoft.Json;

namespace Ecommerce_Comentarios
{
    internal class GestorComentarios
    {
        public SqlConnection conexionBaseDeDatos = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Program.direccionDataBase+";Integrated Security=True");
        List<String> listaErrores = new List<String>();
        public string rutaJson = string.Empty;
        public List<String> ErroresComentario()
        {
            var validaciones = new ValidacionesComentario();
            FluentValidation.Results.ValidationResult validacion = validaciones.Validate(Program.comentario);
            VaciarListaErrores();
            if (validacion.IsValid)
            {
                return null;
            }
            else
            {
                RellenarListaErrores(validacion);
                return listaErrores;
            }

        }
        public void GuardarComentario()
        {
            AbrirConexionBaseDeDatos();
            Program.comentario.Guardar(conexionBaseDeDatos);
            CerrarConexionBaseDeDatos();
        }
        public DataTable Productos()
        {
            AbrirConexionBaseDeDatos();
            SqlCommand selectProductos = SelectSQL("select * from Producto");
            SqlDataAdapter adapter = new SqlDataAdapter(selectProductos);
            DataTable productos = new DataTable();
            adapter.Fill(productos);
            CerrarConexionBaseDeDatos();
            return productos;
        }
        public string PromedioCalificacionesProducto(int fk_idProducto)
        {
            AbrirConexionBaseDeDatos();
            string promedioCalificacionesProducto = Program.producto.PromedioCalificaciones(conexionBaseDeDatos, fk_idProducto);
            CerrarConexionBaseDeDatos();
            return promedioCalificacionesProducto;
        }
        private void VaciarListaErrores()
        {
            listaErrores.Clear();
        }
        private void RellenarListaErrores(FluentValidation.Results.ValidationResult validacion)
        {
            foreach (var error in validacion.Errors)
            {
                listaErrores.Add(error.PropertyName);
                listaErrores.Add(error.ErrorMessage);
            }
        }
        private void AbrirConexionBaseDeDatos()
        {
            conexionBaseDeDatos.Open();
        }
        private void CerrarConexionBaseDeDatos()
        {
            conexionBaseDeDatos.Close();
        }
        private SqlCommand SelectSQL(string select)
        {
            return new SqlCommand(select, conexionBaseDeDatos);
        }
        public string CantidadEstrellasProducto(int estrella, int fk_idProducto)
        {
            AbrirConexionBaseDeDatos();
            SqlCommand select = SelectSQL($"select count(calificacion) from Comentarios where {fk_idProducto} = fk_IdProducto and {estrella} = calificacion");
            select.ExecuteNonQuery();
            SqlDataReader lector = select.ExecuteReader();
            lector.Read();
            string cantidad = lector.GetInt32(0).ToString();
            CerrarConexionBaseDeDatos();
            return cantidad;
        }

        public void ObtenerCarrito()
        {
            try
            {
                string carritoSerializado;
                using (var lector = new StreamReader(rutaJson))
                {
                    carritoSerializado = lector.ReadToEnd();
                }
                if (JsonConvert.DeserializeObject<Carrito>(carritoSerializado) != null)
                {
                    Program.carrito = JsonConvert.DeserializeObject<Carrito>(carritoSerializado);
                }
            }catch (Exception ex)
            {
                
            }
            
        }

        public void CargarCarrito(string rutaCarrito)
        {
            rutaJson = rutaCarrito;
            ObtenerCarrito();
        }

        public void EliminarElementoCarrito(int indice)
        {
            Program.carrito.productos.RemoveAt(indice);
        }
    }
}
