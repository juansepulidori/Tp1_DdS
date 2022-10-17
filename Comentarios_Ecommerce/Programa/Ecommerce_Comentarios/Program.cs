using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce_Comentarios
{
    internal static class Program
    {
        public static string direccionDataBase = @"C:\Users\Pulidori\source\repos\Trabajos Diseño de Sistemas\Comentarios_Ecommerce\Programa\Ecommerce_Comentarios\DataBaseComentarios.mdf";
        public static GestorComentarios gestorComentarios = new GestorComentarios();
        public static Comentario comentario = new Comentario();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IComentarios());
        }
    }
}
