using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Trabajo_Practico_1
{
    internal class Peticion
    {
        public int dadoresNecesarios;
        public DateOnly fecha = new DateOnly();
        public TimeOnly horario = new TimeOnly();
        public string grupoSan;
        public string direccion;
        public string lugar;
        public string localidad;

        //Muestra un listado de todas las peticiones recibidas
        public int VisualizarPeticiones()
        {
            Console.Clear();
            DirectoryInfo di = new DirectoryInfo(@".\Peticion\Pendientes");
            FileInfo[] files = di.GetFiles("*.txt");
            foreach(FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }
            Console.Write("\nIngrese el id de la petición (0 para volver al menu): ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        //Muestra el contenido de una peticion seleccionada
        public int VerPeticion(int id)
        {
            Console.Clear();
            TextReader rPeticion = new StreamReader(@$".\Peticion\Pendientes\Peticion {id}.txt");
            var descripcion = rPeticion.ReadToEnd();
            Console.WriteLine(descripcion);
            Console.Write("\nGenerar turno, ingrese '1 = SI' o '0 = NO': ");
            int opcion = int.Parse(Console.ReadLine());
            while(opcion != 1 && opcion != 0)
            {
                Console.Clear();
                Console.WriteLine(descripcion);
                Console.Write("\nGenerar turno, ingrese '1 = SI' o '0 = NO': ");
                opcion = int.Parse(Console.ReadLine());
            }
            rPeticion.Close();
            return opcion;
        }

        //Genera el turno de una peticion seleccionada
        public void IngresarDatosTurno()
        {
            Console.WriteLine("\n---GENERAR TURNO---");
            Console.Write("Ingrese la fecha de donación (dd/mm/aaaa): ");
            fecha = DateOnly.Parse(Console.ReadLine());
            Console.Write("Ingrese el horario (hh:mm:ss): ");
            horario = TimeOnly.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de donadores mínimos: ");
            decimal d = decimal.Parse(Console.ReadLine());
            Console.Write("Ingrese el grupo sanguíneo requerido: ");
            grupoSan = Console.ReadLine();
            Console.Write("Ingrese la dirección: ");
            direccion = Console.ReadLine();
            Console.Write("Ingrese el lugar: ");
            lugar = Console.ReadLine();
            Console.Write("Ingrese la localidad: ");
            localidad = Console.ReadLine();
            //este es el cálculo que se hace para seleccionar más donadores (60% más de donadores)
            d = 160 * d / 100;
            dadoresNecesarios = (int)Math.Round(d);
        }
        public void GenerarTurno(Socio socio, int id) {
            TextReader rSocio = new StreamReader(@".\Socios\Socios.txt");
            string categoria;
            int i = 0;
            Console.Clear();

            while (rSocio.Peek() >= 0)
            {
                socio.ObtenerDatos(rSocio);
                if (socio.categoria == "Activo" && grupoSan == socio.grupoSanguineo && SocioNoSelect(socio)) i++;
            }
            rSocio = new StreamReader(@".\Socios\Socios.txt");
            if (i >= dadoresNecesarios)
            {
                TextWriter nuevoTurno = File.CreateText(@$".\Peticion\Turnos\Turno {id}.txt");
                StreamWriter selectSocio = File.AppendText(@".\Peticion\SociosSeleccionados.txt");
                nuevoTurno.WriteLine("---FECHA Y HORARIO---");
                nuevoTurno.WriteLine($"{fecha} a las {horario}");
                nuevoTurno.WriteLine("---LUGAR---");
                nuevoTurno.WriteLine($"En: {lugar}\nDirección: {direccion}\nLocalidad: {localidad}");
                nuevoTurno.WriteLine("\n---DONADORES---");
                i =0;
                do
                {
                    socio.ObtenerDatos(rSocio);
                    if (socio.categoria == "Activo" && grupoSan == socio.grupoSanguineo)
                    {
                        Console.WriteLine("---SOCIO APTO PARA DONAR " + (i + 1) + "---");
                        socio.MostrarDatos();
                        nuevoTurno.WriteLine($"DNI: {socio.dni}");
                        nuevoTurno.WriteLine($"Nombre y Apellido: {socio.nombreApellido}");
                        nuevoTurno.WriteLine($"Teléfono: {socio.telefono}");
                        nuevoTurno.WriteLine($"Correo: {socio.email}");
                        nuevoTurno.WriteLine($"Grupo sanguíneo: {socio.grupoSanguineo}");
                        nuevoTurno.WriteLine("----------");
                        Console.WriteLine("----------------------------------------\n");
                        selectSocio.WriteLine(socio.dni);
                        i++;

                    }
                } while (i < dadoresNecesarios);
                Console.WriteLine("\n Turno generado, presione enter para ver el turno...");
                Console.ReadKey();
                rSocio.Close();
                selectSocio.Close();
                nuevoTurno.Close();
                Console.Clear();
                TextReader turno = new StreamReader(@$".\Peticion\Turnos\Turno {id}.txt");
                var mostrar = turno.ReadToEnd();
                Console.WriteLine(mostrar);
                turno.Close();
                File.Move(@$".\Peticion\Pendientes\Peticion {id}.txt", @$".\Peticion\Saldadas\Peticion {id}.txt");
            }
            else
            {
                Console.WriteLine("Lo sentimos no podemos completar la solicitud por falta de donadores");
            }
            Console.ReadKey();
        }
        public bool SocioNoSelect(Socio socio)
        {
            TextReader rSocio = new StreamReader(@".\Peticion\SociosSeleccionados.txt");
            string dni;
            while (rSocio.Peek() >= 0)
            {
                dni = rSocio.ReadLine();
                if (dni == socio.dni)
                {
                    rSocio.Close();
                    return false;
                }
            }
            rSocio.Close();
            return true;
        }
    }
}
