namespace Ecommerce_Diseño
{
    partial class IComentario
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
            this.calificacion_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.opinion_txt = new System.Windows.Forms.TextBox();
            this.aceptar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calificacion_cb
            // 
            this.calificacion_cb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.calificacion_cb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.calificacion_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calificacion_cb.FormattingEnabled = true;
            this.calificacion_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.calificacion_cb.Location = new System.Drawing.Point(43, 71);
            this.calificacion_cb.Name = "calificacion_cb";
            this.calificacion_cb.Size = new System.Drawing.Size(91, 23);
            this.calificacion_cb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opinión";
            // 
            // opinion_txt
            // 
            this.opinion_txt.Location = new System.Drawing.Point(43, 124);
            this.opinion_txt.Multiline = true;
            this.opinion_txt.Name = "opinion_txt";
            this.opinion_txt.Size = new System.Drawing.Size(375, 118);
            this.opinion_txt.TabIndex = 3;
            // 
            // aceptar_btn
            // 
            this.aceptar_btn.Location = new System.Drawing.Point(343, 261);
            this.aceptar_btn.Name = "aceptar_btn";
            this.aceptar_btn.Size = new System.Drawing.Size(75, 23);
            this.aceptar_btn.TabIndex = 4;
            this.aceptar_btn.Text = "Aceptar";
            this.aceptar_btn.UseVisualStyleBackColor = true;
            this.aceptar_btn.Click += new System.EventHandler(this.aceptar_btn_Click);
            // 
            // IComentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 296);
            this.Controls.Add(this.aceptar_btn);
            this.Controls.Add(this.opinion_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calificacion_cb);
            this.Name = "IComentario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox calificacion_cb;
        private Label label1;
        private Label label2;
        private TextBox opinion_txt;
        private Button aceptar_btn;
    }
}