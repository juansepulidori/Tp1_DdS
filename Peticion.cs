using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tp1_DdS
{
    internal class Peticion
    {
        private float cantidadRequerida;
        private int dadoresNecesarios;
        private DateTime fecha = new DateTime();

        public void AtenderPeticion(Socio socio)
        {
            TextReader rCliente = new StreamReader("Clientes.txt");
            TextReader rPeticion = new StreamReader("Peticion.txt");
            fecha = DateTime.Parse(rPeticion.ReadLine());
            cantidadRequerida = float.Parse(rPeticion.ReadLine());
            dadoresNecesarios = int.Parse(rPeticion.ReadLine());
            string categoria;
            int i = 0;
            Console.Clear();

            do
            {
                socio.ObtenerDatos(rCliente);
                categoria = socio.getCategoria();
                if (categoria == "Activo")
                {
                    Console.WriteLine("---SOCIO APTO PARA DONAR " + (i + 1) + "---");
                    socio.MostrarDatos();
                    Console.WriteLine("----------------------------------------\n");
                    i++;
                }
                else
                {
                    if(rCliente.Peek() < 0)
                    {
                        i = dadoresNecesarios;
                        Console.WriteLine("Lo sentimos no podemos completar la solicitud por falta de donadores");
                    }
                }
            }while(i < dadoresNecesarios);
            Console.ReadKey();
            rCliente.Close();
            rPeticion.Close();
        }
    }
}
