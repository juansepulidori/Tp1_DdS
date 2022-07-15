namespace PobreTITO_Programa
{
    partial class RegistrarReclamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.ComboBox();
            this.subcategoria = new System.Windows.Forms.ComboBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Incidente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subincidente";
            // 
            // categoria
            // 
            this.categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoria.FormattingEnabled = true;
            this.categoria.Location = new System.Drawing.Point(121, 36);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(240, 23);
            this.categoria.TabIndex = 2;
            this.categoria.SelectedIndexChanged += new System.EventHandler(this.categoria_SelectedIndexChanged);
            // 
            // subcategoria
            // 
            this.subcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subcategoria.FormattingEnabled = true;
            this.subcategoria.Location = new System.Drawing.Point(121, 73);
            this.subcategoria.Name = "subcategoria";
            this.subcategoria.Size = new System.Drawing.Size(240, 23);
            this.subcategoria.TabIndex = 3;
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(121, 111);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(240, 23);
            this.direccion.TabIndex = 4;
            this.direccion.Leave += new System.EventHandler(this.direccion_Leave);
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(121, 149);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(240, 114);
            this.descripcion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dirección";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generar reclamo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // errorP
            // 
            this.errorP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorP.ContainerControl = this;
            // 
            // RegistrarReclamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 314);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.subcategoria);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarReclamo";
            this.Text = "Registrar Reclamo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrarReclamo_FormClosed);
            this.Load += new System.EventHandler(this.RegistrarReclamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox categoria;
        private ComboBox subcategoria;
        private TextBox direccion;
        private TextBox descripcion;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private ErrorProvider errorP;
    }
}