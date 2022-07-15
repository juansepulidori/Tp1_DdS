using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PobreTITO_Programa
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            contrasena.PasswordChar = '*';
        }
        private void visualizar_Click(object sender, EventArgs e)
        {
            ocultar.BringToFront();
            contrasena.PasswordChar = '\0';
        }
        private void ocultar_Click(object sender, EventArgs e)
        {
            visualizar.BringToFront();
            contrasena.PasswordChar = '*';
        }
        private void usuario_Leave(object sender, EventArgs e)
        {
            if (ValidarEntradaDatos.textosVacios(usuario))
            {
                errorP.SetError(usuario, "No puede estar vacío");
            }
            else
            {
                errorP.Clear();
            }
        }
        private void contrasena_Leave(object sender, EventArgs e)
        {
            if (ValidarEntradaDatos.textosVacios(contrasena))
            {
                errorP.SetError(contrasena, "No puede estar vacío");
            }
            else
            {
                errorP.Clear();
            }
        }
        private void ingreso_Click(object sender, EventArgs e)
        {
            List<string> resultados = Program.gestorPobreTITO.VerificarInicioSesion(usuario.Text, contrasena.Text);
            errorP.Clear();
            if (resultados != null)
            {
                for (int i = 0; i < resultados.Count; i++)
                {
                    switch (resultados[i])
                    {
                        case "usuario":
                            i++;
                            errorP.SetError(usuario, resultados[i]);
                            break;
                        case "contrasena":
                            i++;
                            errorP.SetError(contrasena, resultados[i]);
                            break;
                    }
                }
            }
            else
            {
                Program.registrarReclamo.Show();
                this.Hide();
            }
        }
        private void cancelar_Click(object sender, EventArgs e)
        {
            Program.inicio.Show();
            this.Close();
        }
        private void InicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.inicio.Show();
        }
    }
}
