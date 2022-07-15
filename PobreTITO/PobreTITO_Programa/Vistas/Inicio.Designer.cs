namespace PobreTITO_Programa
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registro = new System.Windows.Forms.Button();
            this.iniSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registro
            // 
            this.registro.Location = new System.Drawing.Point(51, 81);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(103, 23);
            this.registro.TabIndex = 0;
            this.registro.Text = "Registrarse";
            this.registro.UseVisualStyleBackColor = true;
            this.registro.Click += new System.EventHandler(this.registro_Click);
            // 
            // iniSesion
            // 
            this.iniSesion.Location = new System.Drawing.Point(51, 35);
            this.iniSesion.Name = "iniSesion";
            this.iniSesion.Size = new System.Drawing.Size(103, 23);
            this.iniSesion.TabIndex = 1;
            this.iniSesion.Text = "Iniciar Sesion";
            this.iniSesion.UseVisualStyleBackColor = true;
            this.iniSesion.Click += new System.EventHandler(this.iniSesion_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 141);
            this.Controls.Add(this.iniSesion);
            this.Controls.Add(this.registro);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.VisibleChanged += new System.EventHandler(this.Inicio_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private Button registro;
        private Button iniSesion;
    }
}