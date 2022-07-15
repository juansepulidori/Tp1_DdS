namespace PobreTITO_Programa
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.ingreso = new System.Windows.Forms.Button();
            this.visualizar = new System.Windows.Forms.PictureBox();
            this.ocultar = new System.Windows.Forms.PictureBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.visualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(128, 37);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(186, 23);
            this.usuario.TabIndex = 2;
            this.usuario.Leave += new System.EventHandler(this.usuario_Leave);
            // 
            // contrasena
            // 
            this.contrasena.Location = new System.Drawing.Point(128, 78);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(186, 23);
            this.contrasena.TabIndex = 3;
            this.contrasena.Leave += new System.EventHandler(this.contrasena_Leave);
            // 
            // ingreso
            // 
            this.ingreso.Location = new System.Drawing.Point(239, 122);
            this.ingreso.Name = "ingreso";
            this.ingreso.Size = new System.Drawing.Size(75, 23);
            this.ingreso.TabIndex = 4;
            this.ingreso.Text = "Ingresar";
            this.ingreso.UseVisualStyleBackColor = true;
            this.ingreso.Click += new System.EventHandler(this.ingreso_Click);
            // 
            // visualizar
            // 
            this.visualizar.Image = ((System.Drawing.Image)(resources.GetObject("visualizar.Image")));
            this.visualizar.Location = new System.Drawing.Point(350, 76);
            this.visualizar.Name = "visualizar";
            this.visualizar.Size = new System.Drawing.Size(25, 25);
            this.visualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.visualizar.TabIndex = 5;
            this.visualizar.TabStop = false;
            this.visualizar.Click += new System.EventHandler(this.visualizar_Click);
            // 
            // ocultar
            // 
            this.ocultar.Image = ((System.Drawing.Image)(resources.GetObject("ocultar.Image")));
            this.ocultar.Location = new System.Drawing.Point(350, 76);
            this.ocultar.Name = "ocultar";
            this.ocultar.Size = new System.Drawing.Size(25, 25);
            this.ocultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ocultar.TabIndex = 6;
            this.ocultar.TabStop = false;
            this.ocultar.Click += new System.EventHandler(this.ocultar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(128, 122);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 28;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // errorP
            // 
            this.errorP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorP.ContainerControl = this;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 166);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.ingreso);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visualizar);
            this.Controls.Add(this.ocultar);
            this.Name = "InicioSesion";
            this.Text = "Inicio Sesion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InicioSesion_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.visualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usuario;
        private TextBox contrasena;
        private Button ingreso;
        private PictureBox visualizar;
        private PictureBox ocultar;
        private Button cancelar;
        private ErrorProvider errorP;
    }
}