namespace Trabajo_Practico_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu= new Menu();
            Socio socio = new Socio();
            Cuota cuota = new Cuota();
            Donacion donacion = new Donacion();
            Peticion peticion = new Peticion();
            menu.Opciones();
            int opcion = int.Parse(Console.ReadLine());

            while (opcion != 0)
            {
                menu.Acciones(opcion, socio, cuota, peticion);
                menu.Opciones();
                opcion = int.Parse(Console.ReadLine());
            }
        }
    }
}