using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            MostrarProductos();
            ConfigurarElementoControladorComentario();
            eh_controladorComentario.Enabled = HabilitarComentario();
            btn_enviarComentario.Enabled = HabilitarComentario();
            img_estrellaVacia_1.Enabled = HabilitarComentario();
            img_estrellaVacia_2.Enabled = HabilitarComentario();
            img_estrellaVacia_3.Enabled = HabilitarComentario();
            img_estrellaVacia_4.Enabled = HabilitarComentario();
            img_estrellaVacia_5.Enabled = HabilitarComentario();
        }

        private void btn_enviarComentario_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerDatosComentario();
                List<string> erroresComentario = Program.gestorComentarios.ErroresComentario();
                BorrarMensajesDeError();
                if (ElComentarioEsValido(erroresComentario))
                {
                    Program.gestorComentarios.GuardarComentario();
                    MostrarMensaje("Se guardo el comentario");
                    MostrarPromedioCalificacionesProducto();
                    MostrarEstrellasPromedio();
                    GraficarCantidadEstrellasProducto();
                    Program.gestorComentarios.EliminarElementoCarrito(cb_Productos.SelectedIndex);
                    eh_controladorComentario.Enabled = HabilitarComentario();
                    btn_enviarComentario.Enabled = HabilitarComentario();
                    img_estrellaVacia_1.Enabled = HabilitarComentario();
                    img_estrellaVacia_2.Enabled = HabilitarComentario();
                    img_estrellaVacia_3.Enabled = HabilitarComentario();
                    img_estrellaVacia_4.Enabled = HabilitarComentario();
                    img_estrellaVacia_5.Enabled = HabilitarComentario();
                }
                else
                {
                    MostrarErroresComentario(erroresComentario);
                }
            }
            catch (Exception)
            {
                MostrarMensaje("Faltan campos por completar");
            }
        }

        private void cb_Productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            OcultarEstrellas();
            MostrarPromedioCalificacionesProducto();
            MostrarEstrellasPromedio();
            GraficarCantidadEstrellasProducto();
            eh_controladorComentario.Child = txt_opinion;
            eh_controladorComentario.Enabled = HabilitarComentario();
            btn_enviarComentario.Enabled = HabilitarComentario();
            img_estrellaVacia_1.Enabled = HabilitarComentario();
            img_estrellaVacia_2.Enabled = HabilitarComentario();
            img_estrellaVacia_3.Enabled = HabilitarComentario();
            img_estrellaVacia_4.Enabled = HabilitarComentario();
            img_estrellaVacia_5.Enabled = HabilitarComentario();
        }

        private void MostrarProductos()
        {
            DataTable productos = Program.gestorComentarios.Productos();
            cb_Productos.DataSource = productos;
            cb_Productos.ValueMember = "IdProducto";
            cb_Productos.DisplayMember = "nombreProducto";
        }

        private void ObtenerDatosComentario()
        {
            Program.comentario.opinion = txt_opinion.Text;
            Program.comentario.calificacion = calificacion;
            Program.comentario.fechaComentario = DateTime.Now;
            Program.comentario.fkProducto = (int)cb_Productos.SelectedIndex;
        }

        private bool ElComentarioEsValido(List<string> erroresComentario)
        {
            bool condicion = false;
            if (erroresComentario == null)
            {
                condicion = true;
            }
            return condicion;
        }

        private void MostrarErroresComentario(List<string> erroresComentario)
        {
            for (int i = 0; i < erroresComentario.Count; i++)
            {
                switch (erroresComentario[i])
                {
                    case "calificacion":
                        i++;
                        errorProvider1.SetError(img_estrellaRellena_5, erroresComentario[i]);
                        break;
                    case "opinion":
                        i++;
                        errorProvider1.SetError(eh_controladorComentario, erroresComentario[i]);
                        break;
                }
            }
        }

        private void ConfigurarElementoControladorComentario()
        {
            txt_opinion = new System.Windows.Controls.TextBox();
            txt_opinion.TextWrapping = System.Windows.TextWrapping.Wrap;
            txt_opinion.AcceptsReturn = true;
            txt_opinion.SpellCheck.IsEnabled = true;
            txt_opinion.FontSize = 14;
            txt_opinion.FontFamily = new System.Windows.Media.FontFamily("Times New Roman");
            eh_controladorComentario.Child = txt_opinion;
        }

        private void BorrarMensajesDeError()
        {
            errorProvider1.Clear();
        }

        private void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void MostrarPromedioCalificacionesProducto()
        {
            lbl_promedioCalificacionesProducto.Text = Program.gestorComentarios.PromedioCalificacionesProducto(cb_Productos.SelectedIndex);
        }

        private void GraficarCantidadEstrellasProducto()
        {
            ArrayList estrellas = new ArrayList();
            ArrayList cantidad = new ArrayList();

            for (int i = 5; i > 0; i--) {
                estrellas.Add(i.ToString());
                cantidad.Add(Program.gestorComentarios.CantidadEstrellasProducto(i, cb_Productos.SelectedIndex));
            }
            cht_cantidadEstrellas.Series[0].Points.DataBindXY(estrellas, cantidad);

        }

        private bool HabilitarComentario()
        {
            bool habilitar = false;
            foreach (var producto in Program.carrito.productos)
            {
                if (producto.idProducto == cb_Productos.SelectedIndex)
                {
                    habilitar = true;
                    break;
                }
                else
                {
                    habilitar = false;
                }
            }
            return habilitar;
        }

        #region Mostrar Estrellas

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

        private void OcultarEstrellas()
        {
            img_estrellaRellena_1.SendToBack();
            img_estrellaRellena_2.SendToBack();
            img_estrellaRellena_3.SendToBack();
            img_estrellaRellena_4.SendToBack();
            img_estrellaRellena_5.SendToBack();
            img_estrellaVacia_1.BringToFront();
            img_estrellaVacia_2.BringToFront();
            img_estrellaVacia_3.BringToFront();
            img_estrellaVacia_4.BringToFront();
            img_estrellaVacia_5.BringToFront();
        }

        private void MostrarEstrellasPromedio()
        {
            float promedioCalificaciones = float.Parse(lbl_promedioCalificacionesProducto.Text);
            if (promedioCalificaciones == 0)
            {
                img_estrellaVaciaPromedio1.BringToFront();
                img_estrellaVaciaPromedio2.BringToFront();
                img_estrellaVaciaPromedio3.BringToFront();
                img_estrellaVaciaPromedio4.BringToFront();
                img_estrellaVaciaPromedio5.BringToFront();
            }
            else if (promedioCalificaciones >= 1 && promedioCalificaciones < 1.5)
            {
                img_estrellaRellenaPromedio1.BringToFront();
                img_estrellaVaciaPromedio2.BringToFront();
                img_estrellaVaciaPromedio3.BringToFront();
                img_estrellaVaciaPromedio4.BringToFront();
                img_estrellaVaciaPromedio5.BringToFront();
            }
            else if(promedioCalificaciones >= 1.5 && promedioCalificaciones < 2)
            {
                img_estrellaRellenaPromedio1.BringToFront();
                img_estrellaMitadRellenaPromedio2.BringToFront();
                img_estrellaVaciaPromedio3.BringToFront();
                img_estrellaVaciaPromedio4.BringToFront();
                img_estrellaVaciaPromedio5.BringToFront();
            }
            else if (promedioCalificaciones >= 2 && promedioCalificaciones < 2.5)
            {
                img_estrellaRellenaPromedio1.BringToFront();
                img_estrellaRellenaPromedio2.BringToFront();
                img_estrellaVaciaPromedio3.BringToFront();
                img_estrellaVaciaPromedio4.BringToFront();
                img_estrellaVaciaPromedio5.BringToFront();
            }
            else if (promedioCalificaciones >= 2.5 && promedioCalificaciones < 3)
            {
                img_estrellaRellenaPromedio1.BringToFront();
                img_estrellaRellenaPromedio2.BringToFront();
                img_estrellaMitadRellenaPromedio3.BringToFront();
                img_estrellaVaciaPromedio4.BringToFront();
                img_estrellaVaciaPromedio5.BringToFront();
            }
            else if (promedioCalificaciones >= 3 && promedioCalificaciones < 3.5)
            {
                img_estrellaRellenaPromedio1.BringToFront();
                img_estrellaRellenaPromedio2.BringToFront();
                img_estrellaRellenaPromedio3.BringToFront();
                img_estrellaVaciaPromedio4.BringToFront();
                img_estrellaVaciaPromedio5.BringToFront();
            }
            else if (promedioCalificaciones >= 3.5 && promedioCalificaciones < 4)
            {
                img_estrellaRellenaPromedio1.BringToFront();
                img_estrellaRellenaPromedio2.BringToFront();
                img_estrellaRellenaPromedio3.BringToFront();
                img_estrellaMitadRellenaPromedio4.BringToFront();
                img_estrellaVaciaPromedio5.BringToFront();
            }
            else if (promedioCalificaciones >= 4 && promedioCalificaciones < 4.5)
            {
                img_estrellaRellenaPromedio1.BringToFront();
                img_estrellaRellenaPromedio2.BringToFront();
                img_estrellaRellenaPromedio3.BringToFront();
                img_estrellaRellenaPromedio4.BringToFront();
                img_estrellaVaciaPromedio5.BringToFront();
            }
            else if (promedioCalificaciones >= 4.5 && promedioCalificaciones < 5)
            {
                img_estrellaRellenaPromedio1.BringToFront();
                img_estrellaRellenaPromedio2.BringToFront();
                img_estrellaRellenaPromedio3.BringToFront();
                img_estrellaRellenaPromedio4.BringToFront();
                img_estrellaMitadRellenaPromedio5.BringToFront();
            }
            else
            {
                img_estrellaRellenaPromedio1.BringToFront();
                img_estrellaRellenaPromedio2.BringToFront();
                img_estrellaRellenaPromedio3.BringToFront();
                img_estrellaRellenaPromedio4.BringToFront();
                img_estrellaRellenaPromedio5.BringToFront();
            }
        }


        #endregion

        private void cargarCarrito_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Program.gestorComentarios.CargarCarrito(openFileDialog1.FileName);
            }
            eh_controladorComentario.Enabled = HabilitarComentario();
            btn_enviarComentario.Enabled = HabilitarComentario();
            img_estrellaVacia_1.Enabled = HabilitarComentario();
            img_estrellaVacia_2.Enabled = HabilitarComentario();
            img_estrellaVacia_3.Enabled = HabilitarComentario();
            img_estrellaVacia_4.Enabled = HabilitarComentario();
            img_estrellaVacia_5.Enabled = HabilitarComentario();
        }
    }
}
