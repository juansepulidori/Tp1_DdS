using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    internal class Cuota
    {
        private float monto;
        private string metodoPago = "";
        private DateTime fechaVencimiento = new DateTime();
        private string estado = "";

        public void LiquidarCuotas()
        {
            TextReader leer = new StreamReader("Socios.txt");
            StreamWriter agregar = File.AppendText("Cuotas.txt");
            string cadena;
            long dni;
            Console.Clear();
            Console.Write("Ingrese la fecha de la cuota dd/mm/aaaa: ");
            fechaVencimiento = DateTime.Parse(Console.ReadLine());
            Console.Write("Ingrese el monto de la cuota: ");
            monto = float.Parse(Console.ReadLine());
            fechaVencimiento = fechaVencimiento.AddDays(20);
            cadena = leer.ReadLine();
            dni = long.Parse(cadena);
            while (cadena != null)
            {
                agregar.WriteLine(dni);
                agregar.WriteLine(monto);
                agregar.WriteLine(metodoPago);
                agregar.WriteLine(fechaVencimiento);
                agregar.WriteLine(estado);
                for (int i = 0; i < 13; i++)
                {
                    cadena = leer.ReadLine();
                }
                if (cadena != null)
                {
                    dni = long.Parse(cadena);
                }
            }
            Console.WriteLine("Se enviaron todas las cuotas del mes " + fechaVencimiento.Month);
            Console.ReadKey();
            leer.Close();
            agregar.Close();
        }
    }
}
