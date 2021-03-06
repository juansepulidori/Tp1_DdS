using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    internal class Menu
    {
        public void Opciones()
        {
            Console.Clear();
            Console.WriteLine("---MENU DEL PROGRAMA---");
            Console.WriteLine("1- Registrar socio");                                            //Terminada
            Console.WriteLine("2- Visualizar datos");                                           //Terminada
            Console.WriteLine("3- Ver peticiones de donaciones");
            Console.WriteLine("4- Recibir informacion sobre los socios que donaron sangre");
            Console.WriteLine("5- Generar cuotas");                                             //Terminada
            Console.WriteLine("6- Actualizar categorias de socios");                                
            Console.WriteLine("7- Controlar cobranzas");
            Console.WriteLine("8- Listado porcentual de cuotas pagadas");
            Console.WriteLine("0- Salir del programa\n");
            Console.Write("Ingrese su opcion: ");
        }

        public void Acciones(int op, Socio sc, Cuota ct, Peticion pe)
        {
            switch (op)
            {
                case 1:
                    var validations = new SocioValidations();
                    Console.Clear();
                    sc.IngresarSocio();
                    var results = validations.Validate(sc);
                    if (results.IsValid)
                    {
                        Console.Clear();
                        sc.RegistrarSocio();
                    }
                    else
                    {
                        Console.Clear();
                        foreach (var error in results.Errors)
                        {
                            Console.WriteLine(error.PropertyName + ": " + error.ErrorMessage);
                        }
                    }
                    Console.ReadKey();
                    break;
                case 2:
                    sc.VerificarDatos();
                    break;
                case 3:
                    int id = pe.VisualizarPeticiones();
                    if (id != 0)
                    {
                        int desicion = pe.VerPeticion(id);
                        if (desicion != 0) 
                        {
                            pe.IngresarDatosTurno();
                            var validarPeticion = new PeticionValidations();
                            var validarResult = validarPeticion.Validate(pe);
                            if (validarResult.IsValid)
                            {
                                Console.Clear();
                                pe.GenerarTurno(sc, id);
                            }
                            else
                            {
                                Console.Clear();
                                foreach (var error in validarResult.Errors)
                                {
                                    Console.WriteLine(error.PropertyName + ": " + error.ErrorMessage);
                                }
                            }
                            Console.ReadKey();
                        }
                    }
                    break;
                case 5:
                    ct.GenerarCuota(sc);
                    break;
                case 6:
                    sc.ActualizarCategoria();
                    break;

            }
        }
    }
}
