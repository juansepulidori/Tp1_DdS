using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce_Comentarios
{
    public partial class IComentarios : Form
    {
        System.Windows.Controls.TextBox txt_opinion;
        int calificacion;
        public IComentarios()
        {
            InitializeComponent();
        }
        private void IComentarios_Load(object sender, EventArgs e)
        {
            ObtenerProductos();
            txt_opinion = new System.Windows.Controls.TextBox();
            txt_opinion.TextWrapping = System.Windows.TextWrapping.Wrap;
            txt_opinion.AcceptsReturn = true;
            txt_opinion.SpellCheck.IsEnabled = true;
            txt_opinion.FontSize = 14;
            txt_opinion.FontFamily = new System.Windows.Media.FontFamily("Times New Roman");
            controladorOrtografia.Child = txt_opinion;
        }

        private void btn_enviarComentario_Click(object sender, EventArgs e)
        {
            try
            {
                Program.comentario.opinion = txt_opinion.Text;
                Program.comentario.calificacion = calificacion;
                Program.comentario.fechaComentario = DateTime.Now;
                Program.comentario.fkProducto = (int)cb_Productos.SelectedIndex;

                List<string> errores = Program.gestorComentarios.ErroresComentario();
                errorProvider1.Clear();
                if (errores == null)
                {
                    //Program.gestorComentarios.GuardarComentario();
                    MessageBox.Show("Se guardo el comentario");
                }
                else
                {
                    for (int i = 0; i < errores.Count; i++)
                    {
                        switch (errores[i])
                        {
                            case "calificacion":
                                i++;
                                errorProvider1.SetError(img_estrellaRellena_5, errores[i]);
                                break;
                            case "opinion":
                                i++;
                                errorProvider1.SetError(controladorOrtografia, errores[i]);
                                break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan campos por completar");
            }
        }
        private void ObtenerProductos()
        {
            DataTable productos = Program.gestorComentarios.Productos();
            cb_Productos.DataSource = productos;
            cb_Productos.ValueMember = "IdProducto";
            cb_Productos.DisplayMember = "nombreProducto";
        }

        private void img_estrellaVacia_1_Click(object sender, EventArgs e)
        {
            img_estrellaRellena_1.BringToFront();
            img_estrellaVacia_1.SendToBack();
            calificacion = 1;
        }

        private void img_estrellaVacia_2_Click(object sender, EventArgs e)
        {
            img_estrellaRellena_1.BringToFront();
            img_estrellaRellena_2.BringToFront();
            img_estrellaVacia_2.SendToBack();
            calificacion = 2;
        }

        private void img_estrellaVacia_3_Click(object sender, EventArgs e)
        {
            img_estrellaRellena_1.BringToFront();
            img_estrellaRellena_2.BringToFront();
            img_estrellaRellena_3.BringToFront();
            img_estrellaVacia_3.SendToBack();
            calificacion = 3;
        }

        private void img_estrellaVacia_4_Click(object sender, EventArgs e)
        {
            img_estrellaRellena_1.BringToFront();
            img_estrellaRellena_2.BringToFront();
            img_estrellaRellena_3.BringToFront();
            img_estrellaRellena_4.BringToFront();
            img_estrellaVacia_4.SendToBack();
            calificacion = 4;
        }

        private void img_estrellaVacia_5_Click(object sender, EventArgs e)
        {
            img_estrellaRellena_1.BringToFront();
            img_estrellaRellena_2.BringToFront();
            img_estrellaRellena_3.BringToFront();
            img_estrellaRellena_4.BringToFront();
            img_estrellaRellena_5.BringToFront();
            img_estrellaVacia_5.SendToBack();
            calificacion = 5;
        }

        private void img_estrellaRellena_4_Click(object sender, EventArgs e)
        {
            img_estrellaRellena_5.SendToBack();
            img_estrellaVacia_5.BringToFront();
            calificacion = 4;
        }

        private void img_estrellaRellena_3_Click(object sender, EventArgs e)
        {
            img_estrellaRellena_5.SendToBack();
            img_estrellaRellena_4.SendToBack();
            img_estrellaVacia_5.BringToFront();
            img_estrellaVacia_4.BringToFront();
            calificacion = 3;
        }

        private void img_estrellaRellena_2_Click(object sender, EventArgs e)
        {
            img_estrellaRellena_5.SendToBack();
            img_estrellaRellena_4.SendToBack();
            img_estrellaRellena_3.SendToBack();
            img_estrellaVacia_5.BringToFront();
            img_estrellaVacia_4.BringToFront();
            img_estrellaVacia_3.BringToFront();
            calificacion = 2;
        }

        private void img_estrellaRellena_1_Click(object sender, EventArgs e)
        {
            img_estrellaRellena_5.SendToBack();
            img_estrellaRellena_4.SendToBack();
            img_estrellaRellena_3.SendToBack();
            img_estrellaRellena_2.SendToBack();
            img_estrellaVacia_5.BringToFront();
            img_estrellaVacia_4.BringToFront();
            img_estrellaVacia_3.BringToFront();
            img_estrellaVacia_2.BringToFront();
            calificacion = 1;
        }

        
    }
}
