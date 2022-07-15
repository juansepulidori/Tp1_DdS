namespace PobreTITO_Programa
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void registro_Click(object sender, EventArgs e)
        {
            Program.registro.Show();
            this.Hide();
        }

        private void iniSesion_Click(object sender, EventArgs e)
        {
            Program.inicioSesion.Show();
            this.Hide();
        }

        private void Inicio_VisibleChanged(object sender, EventArgs e)
        {
            Program.inicioSesion = null;
            Program.registro = null;
            Program.registrarReclamo = null;
            GC.Collect();
            Program.inicioSesion = new InicioSesion();
            Program.registro = new Registro();
            Program.registrarReclamo = new RegistrarReclamo();
        }
    }
}