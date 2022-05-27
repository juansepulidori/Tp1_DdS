using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    internal class Socio
    {
        public string dni;
        public string nombreApellido;
        public DateTime fechaNacimiento = new();
        public string domicilio;
        public string localidad;
        public string telefono;
        public string email;
        public string grupoSanguineo;
        public string factor;
        public string enfermedadCronica;
        public string medicamento;
        public string categoria;
        public string contrasena;

        public void IngresarSocio()
        {
            Console.Write("Ingrese el dni: ");
            dni = Console.ReadLine();
            Console.Write("Ingrese el nombre y apellido: ");
            nombreApellido = Console.ReadLine();
            Console.Write("Ingrese la fecha de nacimiento dd/mm/aaaa: ");
            fechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.Write("Ingrese el domicilio: ");
            domicilio = Console.ReadLine();
            Console.Write("Ingrese la localidad: ");
            localidad = Console.ReadLine();
            Console.Write("Ingrese el teléfono: ");
            telefono = Console.ReadLine();
            Console.Write("Ingrese el email: ");
            email = Console.ReadLine();
            Console.Write("Ingrese el grupo sanguíneo: ");
            grupoSanguineo = Console.ReadLine();
            factor = "-";
            Console.Write("Ingrese la enfermedad crónica (si no posee colocar \"no\"): ");
            enfermedadCronica = Console.ReadLine();
            Console.Write("Ingrese el/los medicamentos: ");
            medicamento = Console.ReadLine();
            if (enfermedadCronica != "no" || DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1 < 18 || DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1 > 64)
            {
                categoria = "Pasivo";
            }
            else
            {
                categoria = "Activo";
                enfermedadCronica = "";
            }
            Console.Write("Ingrese la contraseña: ");
            contrasena = Console.ReadLine();
        }
        public void RegistrarSocio()
        {
            bool cond = true;
            TextReader leer = new StreamReader(@".\Socios\Socios.txt");
            string cadena = leer.ReadLine();
            while (cadena != null)
            {
                if (cadena == dni)
                {
                    Console.WriteLine("Socio ya registrado");
                    cond = false;
                }
                cadena = leer.ReadLine();
            }
            leer.Close();
            if (cond)
            {
                StreamWriter agregar = File.AppendText(@".\Socios\Socios.txt");
                agregar.WriteLine(dni);
                agregar.WriteLine(nombreApellido);
                agregar.WriteLine(fechaNacimiento);
                agregar.WriteLine(domicilio);
                agregar.WriteLine(localidad);
                agregar.WriteLine(telefono);
                agregar.WriteLine(email);
                agregar.WriteLine(grupoSanguineo);
                agregar.WriteLine(factor);
                agregar.WriteLine(enfermedadCronica);
                agregar.WriteLine(medicamento);
                agregar.WriteLine(categoria);
                agregar.WriteLine(contrasena);
                agregar.Close();
                Console.WriteLine("Se agregó correctamente un nuevo socio");
            }
        }
        public void VerificarDatos()
        {
            Console.Clear();
            TextReader leer = new StreamReader(@".\Socios\Socios.txt");
            string cadena, dniVer, conVer;
            bool cond1 = true, cond2 = true;
            cadena = leer.ReadLine();
            Console.Write("Ingrese el dni: ");
            dniVer = Console.ReadLine();
            Console.Write("Ingrese la contraseña: ");
            conVer = Console.ReadLine();
            while (cadena != null)
            {
                if (cadena == dniVer)
                {
                    dni = cadena;
                    cadena = leer.ReadLine();
                    nombreApellido = cadena;
                    cadena = leer.ReadLine();
                    fechaNacimiento = DateTime.Parse(cadena);
                    cadena = leer.ReadLine();
                    domicilio = cadena;
                    cadena = leer.ReadLine();
                    localidad = cadena;
                    cadena = leer.ReadLine();
                    telefono = cadena;
                    cadena = leer.ReadLine();
                    email = cadena;
                    cadena = leer.ReadLine();
                    grupoSanguineo = cadena;
                    cadena = leer.ReadLine();
                    factor = cadena;
                    cadena = leer.ReadLine();
                    enfermedadCronica = cadena;
                    cadena = leer.ReadLine();
                    medicamento = cadena;
                    cadena = leer.ReadLine();
                    categoria = cadena;
                    cadena = leer.ReadLine();
                    contrasena = cadena;
                    while (cond2)
                    {
                        if(contrasena == conVer)
                        {
                            Console.Clear();
                            Console.WriteLine("-------DATOS-------");
                            MostrarDatos();
                            cond2 = false;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Contraseña incorrecta, si desea salir escriba 'Cancelar'");
                            Console.Write("Ingrese nuevamente su contraseña: ");
                            conVer = Console.ReadLine();
                            if (conVer == "Cancelar") cond2 = false;
                        }
                        
                    }
                    cadena = null;
                    cond1 = false;
                }
                if (cond1)
                {
                    cadena = leer.ReadLine();
                }
            }
            if (cadena == null && cond1)
            {
                Console.WriteLine("No se encontró al socio en la base de datos");
                Console.ReadKey();
            }
            leer.Close();
        }
        public void ActualizarCategoria()
        {
            TextReader leer = new StreamReader(@".\Socios\Socios.txt");
            TextWriter nuevo = File.CreateText(@".\Socios\Socios_Nuevo.txt");
            string cadena = "";
            string cambEstado = "";
            for (int i = 0; i < 3; i++)
            {
                cadena = leer.ReadLine();
                nuevo.WriteLine(cadena);
            }
            while (cadena != null)
            {
                if (DateTime.Today.AddTicks(-DateTime.Parse(cadena).Ticks).Year - 1 > 17)
                {
                    if (DateTime.Today.AddTicks(-DateTime.Parse(cadena).Ticks).Year - 1 > 64)
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            cadena = leer.ReadLine();
                            nuevo.WriteLine(cadena);
                        }
                        cadena = leer.ReadLine();
                        cambEstado = "Pasivo";
                        nuevo.WriteLine(cambEstado);
                        cadena = leer.ReadLine();
                        nuevo.WriteLine(cadena);
                    }
                    else
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            cadena = leer.ReadLine();
                            nuevo.WriteLine(cadena);
                        }
                        if (cadena != "")
                        {
                            cadena = leer.ReadLine();
                            nuevo.WriteLine(cadena);
                            cadena = leer.ReadLine();
                            nuevo.WriteLine(cadena);
                            cadena = leer.ReadLine();
                            nuevo.WriteLine(cadena);
                        }
                        else
                        {
                            cadena = leer.ReadLine();
                            nuevo.WriteLine(cadena);
                            cadena = leer.ReadLine();
                            cambEstado = "Activo";
                            nuevo.WriteLine(cambEstado);
                            cadena = leer.ReadLine();
                            nuevo.WriteLine(cadena);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 10; i++)
                    {
                        cadena = leer.ReadLine();
                        nuevo.WriteLine(cadena);
                    }
                }
                cadena = leer.ReadLine();
                if (cadena != null)
                {
                    nuevo.WriteLine(cadena);
                    cadena = leer.ReadLine();
                    nuevo.WriteLine(cadena);
                    cadena = leer.ReadLine();
                    nuevo.WriteLine(cadena);
                }
            }
            nuevo.Close();
            leer.Close();
            File.Delete(@".\Socios\Socios.txt");
            File.Copy(@".\Socios\Socios_Nuevo.txt", @".\Socios\Socios.txt");
            File.Delete(@".\Socios\Socios_Nuevo.txt");
            Console.Clear();
            Console.WriteLine("Se actualizaron las categorías de los socios");
            Console.ReadKey();
        }
        public void MostrarDatos()
        {
            Console.WriteLine("DNI: " + dni);
            Console.WriteLine("Nombre y apellido: " + nombreApellido);
            Console.WriteLine("Fecha de nacimiento: " + fechaNacimiento);
            Console.WriteLine("Domicilio: " + domicilio);
            Console.WriteLine("Localidad: " + localidad);
            Console.WriteLine("Teléfono: " + telefono);
            Console.WriteLine("E-mail: " + email);
            Console.WriteLine("Grupo sanguíneo: " + grupoSanguineo);
            Console.WriteLine("Factor: " + factor);
            Console.WriteLine("Enfermedad crónica: " + enfermedadCronica);
            Console.WriteLine("Medicamento/s: " + medicamento);
            Console.WriteLine("Categoría: " + categoria);
        }
        public void ObtenerDatos(TextReader rCl)
        {
            dni = rCl.ReadLine();
            nombreApellido = rCl.ReadLine();
            fechaNacimiento = DateTime.Parse(rCl.ReadLine());
            domicilio = rCl.ReadLine();
            localidad = rCl.ReadLine();
            telefono = rCl.ReadLine();
            email = rCl.ReadLine();
            grupoSanguineo = rCl.ReadLine();
            factor = rCl.ReadLine();
            enfermedadCronica = rCl.ReadLine();
            medicamento = rCl.ReadLine();
            categoria = rCl.ReadLine();
            contrasena = rCl.ReadLine();
        }
    }
}
