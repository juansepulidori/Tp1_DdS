using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tp1_DdS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func func = new Func();
            Socio socio = new Socio();
            Cuota cuota = new Cuota();
            Donacion donacion = new Donacion();
            Peticion peticion = new Peticion();

            func.Menu();
            int opcion = int.Parse(Console.ReadLine());

            while (opcion != 0)
            {
                func.Acciones(opcion, socio, cuota, peticion);
                func.Menu();
                opcion = int.Parse(Console.ReadLine());
            }
        }
    }
}
