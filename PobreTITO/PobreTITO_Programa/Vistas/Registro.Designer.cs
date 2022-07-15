namespace PobreTITO_Programa
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Registrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.nacimiento = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.contraRep = new System.Windows.Forms.TextBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.visualizar = new System.Windows.Forms.PictureBox();
            this.ocultar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultar)).BeginInit();
            this.SuspendLayout();
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(258, 278);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(75, 23);
            this.Registrar.TabIndex = 0;
            this.Registrar.Text = "Registrarse";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre y Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Contraseña";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Usuario";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(168, 27);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(165, 23);
            this.dni.TabIndex = 13;
            this.dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dni_KeyPress);
            this.dni.Leave += new System.EventHandler(this.dni_Leave);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(168, 57);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(165, 23);
            this.nombre.TabIndex = 14;
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            this.nombre.Leave += new System.EventHandler(this.nombre_Leave);
            // 
            // nacimiento
            // 
            this.nacimiento.Location = new System.Drawing.Point(168, 88);
            this.nacimiento.Name = "nacimiento";
            this.nacimiento.Size = new System.Drawing.Size(165, 23);
            this.nacimiento.TabIndex = 16;
            this.nacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nacimiento_KeyPress);
            this.nacimiento.Leave += new System.EventHandler(this.nacimiento_Leave);
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(168, 117);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(165, 23);
            this.telefono.TabIndex = 17;
            this.telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefono_KeyPress);
            this.telefono.Leave += new System.EventHandler(this.telefono_Leave);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(168, 146);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(165, 23);
            this.email.TabIndex = 18;
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(168, 175);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(165, 23);
            this.usuario.TabIndex = 21;
            this.usuario.Leave += new System.EventHandler(this.usuario_Leave);
            // 
            // contrasena
            // 
            this.contrasena.Location = new System.Drawing.Point(168, 204);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(165, 23);
            this.contrasena.TabIndex = 24;
            this.contrasena.Leave += new System.EventHandler(this.contrasena_Leave);
            // 
            // errorP
            // 
            this.errorP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorP.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Repetir contraseña";
            // 
            // contraRep
            // 
            this.contraRep.Location = new System.Drawing.Point(168, 233);
            this.contraRep.Name = "contraRep";
            this.contraRep.Size = new System.Drawing.Size(165, 23);
            this.contraRep.TabIndex = 26;
            this.contraRep.Leave += new System.EventHandler(this.contraRep_Leave);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(126, 278);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 27;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // visualizar
            // 
            this.visualizar.Image = global::PobreTITO_Programa.Properties.Resources.visualizar;
            this.visualizar.Location = new System.Drawing.Point(357, 204);
            this.visualizar.Name = "visualizar";
            this.visualizar.Size = new System.Drawing.Size(25, 25);
            this.visualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.visualizar.TabIndex = 28;
            this.visualizar.TabStop = false;
            this.visualizar.Click += new System.EventHandler(this.visualizar_Click);
            // 
            // ocultar
            // 
            this.ocultar.Image = global::PobreTITO_Programa.Properties.Resources.Ocultar;
            this.ocultar.Location = new System.Drawing.Point(357, 204);
            this.ocultar.Name = "ocultar";
            this.ocultar.Size = new System.Drawing.Size(25, 25);
            this.ocultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ocultar.TabIndex = 29;
            this.ocultar.TabStop = false;
            this.ocultar.Click += new System.EventHandler(this.ocultar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 322);
            this.Controls.Add(this.visualizar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.contraRep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.email);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.nacimiento);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.ocultar);
            this.Name = "Registro";
            this.Text = "Registro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registro_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Registrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private TextBox dni;
        private TextBox nombre;
        private TextBox nacimiento;
        private TextBox telefono;
        private TextBox email;
        private TextBox usuario;
        private TextBox contrasena;
        private ErrorProvider errorP;
        private TextBox contraRep;
        private Label label4;
        private Button cancelar;
        private PictureBox visualizar;
        private PictureBox ocultar;
    }
}