using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FluentValidation;
using System.Data;

namespace PobreTITO_Programa
{
    internal class GestorPobreTITO
    {
        int idPersona;
        private SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pulidori\source\repos\Trabajos Diseño de Sistemas\PobreTITO\PobreTITO_Programa\BD\BaseDatos.mdf;Integrated Security=True");

        //Gestiona el Registro
        public List<string> VerificarRegistro(string dni, string nombreApellido, DateOnly nacimiento, string telefono, string email, string usuario, string contrasena, string contraRep)
        {
            Persona persona = new Persona(dni, nombreApellido, nacimiento, telefono, email, usuario, contrasena);
            var validacion = new ValidarRegistro();
            var results = validacion.Validate(persona);
            List<string> resultados = new List<string>();
            if (!results.IsValid || contrasena != contraRep)
            {
                foreach (var error in results.Errors)
                {
                    resultados.Add(error.PropertyName);
                    resultados.Add(error.ErrorMessage);
                }
                if (contrasena != contraRep)
                {
                    resultados.Add("contraRep");
                    resultados.Add("Las contraseñas no son iguales");
                }
                return resultados;
            }
            else
            {
                conexion.Open();
                persona.NuevaPersona(conexion);
                MessageBox.Show("Persona registrada");
                conexion.Close();
                return null;
            }
        }

        //Gestiona el Inicio de Sesión
        public List<string> VerificarInicioSesion(string usuario, string password)
        {
            conexion.Open();
            List<string> resultados = new List<string>();
            SqlCommand select = new SqlCommand($"select * from Persona where usuario = '{usuario}'", conexion);
            SqlDataReader lector = select.ExecuteReader();
            if (lector.Read())
            {
                idPersona = lector.GetInt32(0);
                Persona persona = new Persona(lector.GetString(1),lector.GetString(2), DateOnly.Parse(lector.GetString(3)), lector.GetString(4), lector.GetString(5), lector.GetString(6), lector.GetString(7));
                if (persona.contrasena != password)
                {
                    resultados.Add("contrasena");
                    resultados.Add("Contraseña incorrecta");
                }
                else
                {
                    resultados = null;
                }
            }
            else
            {
                resultados.Add("usuario");
                resultados.Add("Usuario no encontrado o incorrecto");
            }
            lector.Close();
            conexion.Close();
            return resultados;
        }

        //Obtener Incidentes
        public DataTable ObtenerIncidentes()
        {
            conexion.Open();
            SqlCommand select = new SqlCommand("select * from Incidente", conexion);
            DataTable resultados = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(select);
            adapter.Fill(resultados);
            conexion.Close();
            return resultados;
        }

        //Obtener subincidentes
        public DataTable ObtenerSubincidentes(int id)
        {
            conexion.Open();
            SqlCommand select = new SqlCommand($"select * from SubIncidente where Incidente_Id = {id}", conexion);
            DataTable resultados = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(select);
            adapter.Fill(resultados);
            conexion.Close();
            return resultados;
        }

        //Gestiona el reclamo
        public void GestionarReclamo(int subincidente, string direccion, string descripcion)
        {
            conexion.Open();
            Reclamo reclamo = new Reclamo(direccion, descripcion);
            reclamo.NuevoReclamo(idPersona, subincidente, conexion);
            MessageBox.Show("Reclamo registrado con exito");
            conexion.Close();
        }
    }
}
