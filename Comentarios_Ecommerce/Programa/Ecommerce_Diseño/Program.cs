namespace Ecommerce_Diseño
{
    internal static class Program
    {
        public static GestorEcommerce gestorEcommerce = new GestorEcommerce();
        public static ValidarComentario validarComentario = new ValidarComentario();
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new IComentario());
        }
    }
}