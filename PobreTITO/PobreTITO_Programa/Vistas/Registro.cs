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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            contrasena.PasswordChar = '*';
            contraRep.PasswordChar = '*';
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> resultados = Program.gestorPobreTITO.VerificarRegistro(dni.Text, nombre.Text, DateOnly.Parse(nacimiento.Text), telefono.Text, email.Text, usuario.Text, contrasena.Text, contraRep.Text);
                if(resultados != null)
                {
                    errorP.Clear();
                    for (int i = 0; i < resultados.Count; i++)
                    {
                        switch (resultados[i])
                        {
                            case "dni":
                                i++;
                                errorP.SetError(dni, resultados[i]);
                                break;
                            case "nombreApellido":
                                i++;
                                errorP.SetError(nombre, resultados[i]);
                                break;
                            case "nacimiento":
                                i++;
                                errorP.SetError(nacimiento, resultados[i]);
                                break;
                            case "telefono":
                                i++;
                                errorP.SetError(telefono, resultados[i]);
                                break;
                            case "email":
                                i++;
                                errorP.SetError(email, resultados[i]);
                                break;
                            case "usuario":
                                i++;
                                errorP.SetError(usuario, resultados[i]);
                                break;
                            case "contrasena":
                                i++;
                                errorP.SetError(contrasena, resultados[i]);
                                break;
                            case "contraRep":
                                i++;
                                errorP.SetError(contraRep, resultados[i]);
                                break;
                        }
                    }
                }
                else
                {
                    Program.inicio.Show();
                    this.Close();
                }
            }
            catch (Exception)
            {
                errorP.SetError(nacimiento, "Fecha inválida dd/mm/aaaa");
            }
        }

        //Validaciones y funciones varias
        private void dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarEntradaDatos.soloNumeros(e);
            if (!valida)
            {
                errorP.SetError(dni, null);
            }
            else
            {
                errorP.Clear();
            }
        }
        private void dni_Leave(object sender, EventArgs e)
        {
            if (ValidarEntradaDatos.textosVacios(dni))
            {
                errorP.SetError(dni, "No puede estar vacío");
            }
            else
            {
                errorP.Clear();
            }
        }
        private void nacimiento_Leave(object sender, EventArgs e)
        {
            DateOnly fecha;
            if(!DateOnly.TryParse(nacimiento.Text, out fecha))
            {
                errorP.SetError(nacimiento, "Fecha inválida dd/mm/aaaa");
            }
            else
            {
                errorP.Clear();
            }
        }
        private void nacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarEntradaDatos.soloNumerosFecha(e);
            if (!valida)
            {
                errorP.SetError(dni, null);
            }
            else
            {
                errorP.Clear();
            }
        }
        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarEntradaDatos.soloLetras(e);
            if (!valida)
            {
                errorP.SetError(nombre, null);
            }
            else
            {
                errorP.Clear();
            }
        }
        private void nombre_Leave(object sender, EventArgs e)
        {
            if (ValidarEntradaDatos.textosVacios(nombre))
            {
                errorP.SetError(nombre, "No puede estar vacío");
            }
            else
            {
                errorP.Clear();
            }
        }
        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarEntradaDatos.soloNumeros(e);
            if (!valida)
            {
                errorP.SetError(telefono, null);
            }
            else
            {
                errorP.Clear();
            }
        }
        private void telefono_Leave(object sender, EventArgs e)
        {
            if (ValidarEntradaDatos.textosVacios(telefono))
            {
                errorP.SetError(telefono, "No puede estar vacío");
            }
            else
            {
                errorP.Clear();
            }
        }
        private void email_Leave(object sender, EventArgs e)
        {
            if (ValidarEntradaDatos.textosVacios(email))
            {
                errorP.SetError(email, "No puede estar vacío");
            }
            else
            {
                errorP.Clear();
            }
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
        private void contraRep_Leave(object sender, EventArgs e)
        {
            if (ValidarEntradaDatos.textosVacios(contraRep))
            {
                errorP.SetError(contraRep, "No puede estar vacío");
            }
            else
            {
                errorP.Clear();
            }
        }
        private void cancelar_Click(object sender, EventArgs e)
        {
            Program.inicio.Show();
            this.Close();
        }
        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.inicio.Show();
        }
        private void ocultar_Click(object sender, EventArgs e)
        {
            visualizar.BringToFront();
            contrasena.PasswordChar = '*';
        }
        private void visualizar_Click(object sender, EventArgs e)
        {
            ocultar.BringToFront();
            contrasena.PasswordChar = '\0';
        }
    }
}
