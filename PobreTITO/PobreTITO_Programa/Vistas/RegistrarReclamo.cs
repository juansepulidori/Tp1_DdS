using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace PobreTITO_Programa
{
    public partial class RegistrarReclamo : Form
    {
        public RegistrarReclamo()
        {
            InitializeComponent();
        }

        private void LlenarIncidentes()
        {
            DataTable dt = Program.gestorPobreTITO.ObtenerIncidentes();
            categoria.DisplayMember = "tipo";
            categoria.ValueMember = "Id";
            categoria.DataSource = dt;
        }

        private void LlenarSubincidentes(int id)
        {
            DataTable dt = Program.gestorPobreTITO.ObtenerSubincidentes(id);
            subcategoria.DataSource = dt;
            subcategoria.ValueMember = "Id";
            subcategoria.DisplayMember = "tipo";
        }

        private void categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = (int)categoria.SelectedValue;
            if ((int)categoria.SelectedIndex != -1)
            {
                LlenarSubincidentes(id);
            }
        }

        private void RegistrarReclamo_Load(object sender, EventArgs e)
        {
            LlenarIncidentes();
        }

        private void RegistrarReclamo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarEntradaDatos.textosVacios(direccion))
            {
                errorP.SetError(direccion, "No puede estar vacío");
            }
            else
            {
                errorP.Clear();
                Program.gestorPobreTITO.GestionarReclamo((int)subcategoria.SelectedValue, direccion.Text, descripcion.Text);
            }
        }
        private void direccion_Leave(object sender, EventArgs e)
        {
            if (ValidarEntradaDatos.textosVacios(direccion))
            {
                errorP.SetError(direccion, "No puede estar vacío");
            }
            else
            {
                errorP.Clear();
            }
        }
    }
}
