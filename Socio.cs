using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Tp1_DdS
{
    internal class Socio
    {
        private long dni;
        private string nombreApellido;
        private DateTime fechaNacimiento = new DateTime();
        private string domicilio;
        private string localidad;
        private long telefono;
        private string email;
        private string grupoSanguineo;
        private string factor;
        private string enfermedadCronica;
        private string medicamento;
        private string categoria;
        private string contrasena;

        public void AgregarSocio()
        {
            Console.Clear();
            bool cond = true;
            Console.Write("Ingrese el dni: ");
            string dniVer = Console.ReadLine();
            TextReader leer = new StreamReader("Clientes.txt");
            string cadena = leer.ReadLine();
            while (cadena != null)
            {
                if (cadena == dniVer)
                {
                    Console.WriteLine("Socio ya registrado");
                    cond = false;
                }
                cadena = leer.ReadLine();
            }
            leer.Close();
            if (cond)
            {
                dni = long.Parse(dniVer);
                Console.Write("Ingrese el nombre y apellido: ");
                nombreApellido = Console.ReadLine();
                Console.Write("Ingrese la fecha de nacimiento dd/mm/aaaa: ");
                fechaNacimiento = DateTime.Parse(Console.ReadLine());
                Console.Write("Ingrese el domicilio: ");
                domicilio = Console.ReadLine();
                Console.Write("Ingrese la localidad: ");
                localidad = Console.ReadLine();
                Console.Write("Ingrese el teléfono: ");
                telefono = long.Parse(Console.ReadLine());
                Console.Write("Ingrese el email: ");
                email = Console.ReadLine();
                Console.Write("Ingrese el grupo sanguíneo: ");
                grupoSanguineo = Console.ReadLine();
                Console.Write("Ingrese el factor: ");
                factor = Console.ReadLine();
                Console.Write("Ingrese la enfermedad crónica (si no posee colocar \"no\"): ");
                enfermedadCronica = Console.ReadLine();
                Console.Write("Ingrese el/los medicamentos: ");
                medicamento = Console.ReadLine();
                if(enfermedadCronica != "no" || DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1 < 18 || DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1 > 64)
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

                StreamWriter agregar = File.AppendText("Clientes.txt");
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
            Console.ReadKey();
        }
        public void VerificarDatos()
        {
            Console.Clear();
            TextReader leer = new StreamReader("Clientes.txt");
            string cadena, dniVer;
            bool cond = true;
            cadena = leer.ReadLine();
            Console.Write("Ingrese el dni: ");
            dniVer = Console.ReadLine();
            while (cadena != null)
            {
                if(cadena == dniVer)
                {
                    Console.Clear();
                    Console.WriteLine("-------DATOS-------");
                    dni = long.Parse(cadena);
                    cadena = leer.ReadLine();
                    nombreApellido = cadena;
                    cadena = leer.ReadLine();
                    fechaNacimiento = DateTime.Parse(cadena);
                    cadena = leer.ReadLine();
                    domicilio = cadena;
                    cadena = leer.ReadLine();
                    localidad = cadena;
                    cadena = leer.ReadLine();
                    telefono = long.Parse(cadena);
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
                    MostrarDatos();
                    cadena = null;
                    cond = false;
                    Console.ReadKey();
                }
                if (cond)
                {
                    cadena = leer.ReadLine();
                }
            }
            if(cadena == null && cond)
            {
                Console.WriteLine("No se encontró al socio en la base de datos");
                Console.ReadKey();
            }
            leer.Close();
        }
        public void ActualizarCategoria()
        {
            TextReader leer = new StreamReader("Clientes.txt");
            TextWriter nuevo = File.CreateText("Clientes_Nuevo.txt");
            string cadena = "";
            string cambEstado = "";
            for(int i = 0; i < 3; i++){ 
                cadena = leer.ReadLine();
                nuevo.WriteLine(cadena);
            }
            while (cadena != null)
            {
                if (DateTime.Today.AddTicks(-DateTime.Parse(cadena).Ticks).Year - 1 > 17)
                {
                    if (DateTime.Today.AddTicks(-DateTime.Parse(cadena).Ticks).Year - 1 > 64)
                    {
                        for(int i = 0; i < 8; i++)
                        {
                            cadena= leer.ReadLine();
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
                    for(int i = 0;i<10 ;i++ )
                    {
                        cadena = leer.ReadLine();
                        nuevo.WriteLine(cadena);
                    }
                }
                cadena = leer.ReadLine();
                if(cadena != null)
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
            File.Delete("Clientes.txt");
            File.Copy("Clientes_Nuevo.txt", "Clientes.txt");
            File.Delete("Clientes_Nuevo.txt");
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
            dni = int.Parse(rCl.ReadLine());
            nombreApellido = rCl.ReadLine();
            fechaNacimiento = DateTime.Parse(rCl.ReadLine());
            domicilio = rCl.ReadLine();
            localidad = rCl.ReadLine();
            telefono = long.Parse(rCl.ReadLine());
            email = rCl.ReadLine();
            grupoSanguineo = rCl.ReadLine();
            factor = rCl.ReadLine();
            enfermedadCronica = rCl.ReadLine();
            medicamento = rCl.ReadLine();
            categoria = rCl.ReadLine();
            contrasena = rCl.ReadLine();
        }
        public string getCategoria()
        {
            return categoria;
        }
    }
}
