using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FluentValidation;

namespace PobreTITO_Programa
{
    internal class ValidarRegistro: AbstractValidator<Persona>
    {
        private SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pulidori\source\repos\Trabajos Diseño de Sistemas\PobreTITO\PobreTITO_Programa\BD\BaseDatos.mdf;Integrated Security=True");
        public ValidarRegistro()
        {
            RuleFor(x => x.dni).MinimumLength(7).WithMessage("La cantidad de dígitos mínima es 7")
                                .MaximumLength(8).WithMessage("La cantidad de dígitos máximos es 8")
                                .Must(VerDNIRep).WithMessage("El DNI ya está registrado")
                                .NotEmpty().WithMessage("No debe estar vacío");
            RuleFor(x => x.nombreApellido).MaximumLength(80).WithMessage("Máximo 80 caracteres")
                                .NotEmpty().WithMessage("No debe estar vacío");
            RuleFor(x => x.nacimiento).Must(VerNac).WithMessage("Fecha de nacimiento inválida");
            RuleFor(x => x.telefono).Length(10).WithMessage("Teléfono no válido")
                                .NotEmpty().WithMessage("No debe estar vacío");
            RuleFor(x => x.email).EmailAddress().WithMessage("Correo no válido")
                                .NotEmpty().WithMessage("No debe estar vacío");
            RuleFor(x => x.usuario).MaximumLength(15).WithMessage("Máximo 15 caracteres")
                                .Must(VerUsu).WithMessage("El nombre de usuario ya está registrado")
                                .NotEmpty().WithMessage("No debe estar vacío");
            RuleFor(x => x.contrasena).MaximumLength(15).WithMessage("Máximo 15 caracteres")
                                .Must(VerCon).WithMessage("Debe tener una letra, un número y un caracter especial (!#@?¿¡&$)")
                                .NotEmpty().WithMessage("No debe estar vacío");
        }
        private bool VerDNIRep(string dni)
        {
            conexion.Open();
            SqlCommand select = new SqlCommand($"select dni from Persona where dni = '{dni}'", conexion);
            SqlDataReader lector = select.ExecuteReader();
            if (lector.Read())
            {
                lector.Close();
                conexion.Close();
                return false;
            }
            else
            {
                lector.Close();
                conexion.Close();
                return true;
            }
        }
        private bool VerNac(DateOnly time)
        {
            if (time.Year > 1900 && time.Year < DateTime.Now.Year) return true;
            return false;
        }
        private bool VerUsu(string usuario)
        {
            conexion.Open();
            SqlCommand select = new SqlCommand($"select dni from Persona where usuario = '{usuario}'", conexion);
            SqlDataReader lector = select.ExecuteReader();
            if (lector.Read())
            {
                lector.Close();
                conexion.Close();
                return false;
            }
            else
            {
                lector.Close();
                conexion.Close();
                return true;
            }
        }
        private bool VerCon(string contrasena)
        {
            Regex letras = new Regex(@"[a-zA-z]");
            Regex numeros = new Regex(@"[0-9]");
            Regex caracEsp = new Regex("[!\"#\\$%&'()*+,-./:;=?@\\[\\]^_`{|}~]");
            if (!letras.IsMatch(contrasena))
            {
                return false;
            }
            if (!numeros.IsMatch(contrasena))
            {
                return false;
            }
            if (!caracEsp.IsMatch(contrasena))
            {
                return false;
            }
            return true;
        }
    }
}
