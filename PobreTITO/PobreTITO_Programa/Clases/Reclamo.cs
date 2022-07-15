using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PobreTITO_Programa
{
    internal class Reclamo
    {
        public DateTime fecha { get; set; }
        public string direccion { get; set; }
        public string descripcion { get; set; }

        public Reclamo(string direccion, string descripcion)
        {
            fecha = DateTime.Now;
            this.direccion = direccion;
            this.descripcion = descripcion;
        }

        public void NuevoReclamo(int idP, int idSI, SqlConnection connection)
        {
            SqlCommand insert = new SqlCommand($"insert into Reclamo values('{fecha}','{direccion}','{descripcion}', {idP}, {idSI})", connection);
            insert.ExecuteNonQuery();
        }
    }
}
