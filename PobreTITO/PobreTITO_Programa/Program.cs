using System.Data.SqlClient;
namespace PobreTITO_Programa
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static Inicio inicio = new Inicio();
        public static InicioSesion inicioSesion = new InicioSesion();
        public static RegistrarReclamo registrarReclamo = new RegistrarReclamo();
        public static Registro registro = new Registro();
        public static GestorPobreTITO gestorPobreTITO = new GestorPobreTITO();
        public static SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pulidori\source\repos\Trabajos Diseño de Sistemas\PobreTITO\PobreTITO_Programa\BD\BaseDatos.mdf;Integrated Security=True");
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(inicio);
        }
    }
}