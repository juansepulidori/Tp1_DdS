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
        private DateTime fechaVencimiento1 = new DateTime();
        private DateTime fechaVencimiento2 = new DateTime();
        private string estado = "Pendiente";

        public void GenerarCuota(Socio socio)
        {
            // Para usar la funcion cambiar el numero al dia actual (ejemplo: si hoy es 21/4/2022 cambiar en el if a 21)
            if (DateTime.Now.Day == 5)
            {
                bool condition = true;
                TextReader verificar = new StreamReader("Cuotas.txt");
                while (verificar.Peek() >= 0 && condition)
                {
                    ObtenerDatos(verificar);
                    if (DateTime.Now.Month == fechaVencimiento1.AddDays(-14).Month)
                    {
                        Console.Clear();
                        Console.WriteLine($"Las cuotas para el mes {fechaVencimiento1.AddDays(-14).Month} del año {fechaVencimiento1.AddDays(-14).Year} ya están generadas");
                        condition = false;
                        Console.ReadKey();
                    }
                }
                verificar.Close();
                if (condition)
                {
                    CuotaValidations cuotaValidations = new CuotaValidations();
                    TextReader leer = new StreamReader("Socios.txt");
                    StreamWriter agregar = File.AppendText("Cuotas.txt");
                    Console.Clear();
                    float montoB;
                    fechaVencimiento1 = DateTime.Today.AddDays(14);
                    fechaVencimiento2 = fechaVencimiento1.AddDays(7);
                    Console.Write("Ingrese el monto de la cuota para los activos: ");
                    monto = float.Parse(Console.ReadLine());
                    Console.Write("Ingrese el monto de la cuota para los pasivos: ");
                    montoB = float.Parse(Console.ReadLine());
                    while (cuotaValidations.ValidarMonto(monto, montoB))
                    {
                        Console.Clear();
                        Console.WriteLine("Montos incorrectos, no pueden ser menores a 1, ingrese nuevamente los montos");
                        Console.Write("Ingrese el monto de la cuota para los activos: ");
                        monto = float.Parse(Console.ReadLine());
                        Console.Write("Ingrese el monto de la cuota para los pasivos: ");
                        montoB = float.Parse(Console.ReadLine());
                    }
                    while (leer.Peek() >= 0)
                    {
                        socio.ObtenerDatos(leer);
                        agregar.WriteLine(socio.dni);
                        if (socio.categoria == "Activo")
                        {
                            agregar.WriteLine(monto);
                        }
                        else
                        {
                            agregar.WriteLine(montoB);
                        }
                        agregar.WriteLine(metodoPago);
                        agregar.WriteLine(fechaVencimiento1);
                        agregar.WriteLine(fechaVencimiento2);
                        agregar.WriteLine(estado);

                    }
                    Console.WriteLine($"Se generaron todas las cuotas del mes {fechaVencimiento1.AddDays(-14).Month} del año {fechaVencimiento1.AddDays(-14).Year}");
                    Console.ReadKey();
                    leer.Close();
                    agregar.Close();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No es el día para generar las cuotas");
                Console.ReadKey();
            }
            
            
        }
        public void ObtenerDatos(TextReader texto)
        {
            texto.ReadLine();
            monto = float.Parse(texto.ReadLine());
            metodoPago = texto.ReadLine();
            fechaVencimiento1 = DateTime.Parse(texto.ReadLine());
            fechaVencimiento2 = DateTime.Parse(texto.ReadLine());
            estado = texto.ReadLine();
        }
    }
}
