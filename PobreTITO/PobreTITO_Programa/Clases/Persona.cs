using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PobreTITO_Programa
{
    internal class Persona
    {
        public string dni { get; set; }
        public string nombreApellido { get; set; }
        public DateOnly nacimiento { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string contrasena { get; set; }
        public string usuario { get; set; }

        public Persona(string dni, string nombreApellido, DateOnly nacimiento, string telefono, string email, string usuario, string contrasena)
        {
            this.dni = dni;
            this.nombreApellido = nombreApellido;
            this.nacimiento = nacimiento;
            this.telefono = telefono;
            this.email = email;
            this.contrasena = contrasena;
            this.usuario = usuario;
        }
        public Persona()
        {

        }

        public void NuevaPersona(SqlConnection connection)
        {
            SqlCommand insert = new SqlCommand($"insert into Persona values('{dni}', '{nombreApellido}', '{nacimiento}', '{telefono}', '{email}', '{usuario}', '{contrasena}')", connection);
            insert.ExecuteNonQuery();
        }
    }
}
