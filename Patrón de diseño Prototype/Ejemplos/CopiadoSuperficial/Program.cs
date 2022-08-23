using System;
namespace CopiadoExterno
{
    public interface IAuto
    {
        public IAuto Clonar();
        public void CambiarColor(string color);
        public void CambiarModelo(string modelo);
        public void MostrarDatos();
    }

    public class Citroen : IAuto
    {
        private string modelo;
        public int año;
        protected int cantidadPuertas;
        private string color;

        public Citroen(string modelo, int año, int cantidadPuertas, string color)
        {
            this.modelo = modelo;
            this.año = año;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
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
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---Este es el auto 1---");
            IAuto auto1 = new Citroen("C4 Cactus", 2022, 4, "Blanco");
            auto1.MostrarDatos();
            Console.ReadKey();

            Console.WriteLine("\n-----------------------------------------------------------");
            
            Console.WriteLine("\n---Este es el auto 2 clonado del auto 1---");
            IAuto auto2 = auto1.Clonar();
            auto2.CambiarColor("Negro");
            auto2.MostrarDatos();
            Console.WriteLine("\n---Este es el auto 1---");
            auto1.MostrarDatos();
        }
    }
}