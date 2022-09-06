namespace Ecommerce_Diseño
{
    public partial class IComentario : Form
    {
        public IComentario()
        {
            InitializeComponent();
        }

        private void aceptar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Program.gestorEcommerce.GestionarComentario(int.Parse(calificacion_cb.Text), opinion_txt.Text);
            }catch (Exception)
            {
                MessageBox.Show("Faltan campos por completar");
            }
            
        }
    }
}