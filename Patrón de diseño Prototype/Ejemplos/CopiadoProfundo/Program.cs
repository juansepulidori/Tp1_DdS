using System;
namespace CopiadoProfundo
{
    public interface IAuto
    {
        public IAuto Clonar();
        public void CambiarColor(string color);
        public void CambiarModelo(string modelo);
        public void MostrarDatos();
    }

    public interface IMotor
    {
        public void MostrarDatos();
        public void CambiarIdMotor(int idMotor);
        public IMotor Clonar();

    }

    public class Citroen : IAuto
    {
        private string modelo;
        public int año;
        protected int cantidadPuertas;
        private string color;
        public Motor motor;

        public Citroen(string modelo, int año, int cantidadPuertas, string color, Motor motor)
        {
            this.modelo = modelo;
            this.año = año;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
            this.motor = motor;
        }
        public IAuto Clonar()
        {
            return (Citroen)this.MemberwiseClone();
        }
        public void CambiarColor(string color)
        {
            this.color = color;
        }
        public void CambiarModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public void MostrarDatos()
        {
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Año: {año}");
            Console.WriteLine($"Cantidad de puertas: {cantidadPuertas}");
            Console.WriteLine($"Color: {color}");
            motor.MostrarDatos();
        }
    }

    public class Motor : IMotor
    {
        private int idMotor;
        private double velocidadMaxima;

        public Motor(int idMotor, double velocidadMaxima)
        {
            this.idMotor = idMotor;
            this.velocidadMaxima = velocidadMaxima;
        }
        public void MostrarDatos()
        {
            Console.WriteLine("Y este es su motor:");
            Console.WriteLine($"Id: {idMotor}");
            Console.WriteLine($"Velocidad máxima: {velocidadMaxima} Km/h");
        }
        public void CambiarIdMotor(int idMotor)
        {
            this.idMotor = idMotor;
        }
        public IMotor Clonar()
        {
            return (Motor)this.MemberwiseClone();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Copiado superficial del auto");
            Console.WriteLine("\n---Este es el auto 1---");
            Citroen auto1 = new ("C4 Cactus", 2022, 4, "Blanco", new Motor(1254, 245.24));
            auto1.MostrarDatos();
            Console.WriteLine("\n---Este es el auto 2 clonado del auto 1---");
            Citroen auto2 = (Citroen)auto1.Clonar();
            auto2.CambiarColor("Negro");
            auto2.MostrarDatos();
            Console.WriteLine("\nProblema: El mismo motor se debe introducir en 2 autos diferentes (mismo IdMotor)");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Solución 1: cambiar id del motor del auto 2");
            auto2.motor.CambiarIdMotor(1255);
            Console.WriteLine("\n---Este es el auto 1---");
            auto1.MostrarDatos();
            Console.WriteLine("\n---Este es el auto 2 clonado del auto 1---");
            auto2.MostrarDatos();
            Console.WriteLine("\nConclusión: no funciona");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Solución 2: instanciar un nuevo motor para el auto 2");
            auto2.motor = new Motor(1254, 245.24);
            Console.WriteLine("\n---Este es el auto 1---");
            auto1.MostrarDatos();
            Console.WriteLine("\n---Este es el auto 2 clonado del auto 1---");
            auto2.MostrarDatos();
            Console.WriteLine("\nConclusión: funciona");
            Console.WriteLine("Desventaja: Debemos definir siempre todos los valores del motor cada vez que se haga un copiado profundo");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Solución 3: a Motor se le implementa una interfaz con el método clonar");
            auto2 = (Citroen)auto1.Clonar();
            auto2.motor = (Motor)auto1.motor.Clonar();
            auto2.motor.CambiarIdMotor(1254);
            auto2.CambiarColor("Negro");
            Console.WriteLine("\n---Este es el auto 1---");
            auto1.MostrarDatos();
            Console.WriteLine("\n---Este es el auto 2 clonado del auto 1---");
            auto2.MostrarDatos();
            Console.WriteLine("\nConclusión: funciona");
            Console.WriteLine("Desventaja: Debemos modificar mucho código si la clase ya está implementada");
            Console.ReadKey();

        }
    }
}