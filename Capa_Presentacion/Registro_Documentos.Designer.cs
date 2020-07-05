namespace Capa_Presentacion
{
    partial class Registro_Documentos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ArchivoBtn = new System.Windows.Forms.Button();
            this.RemitenteTxt = new System.Windows.Forms.TextBox();
            this.AsuntoTxt = new System.Windows.Forms.TextBox();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.Rutalbl = new System.Windows.Forms.Label();
            this.SubirArchivoBtn = new System.Windows.Forms.Button();
            this.comboArea = new System.Windows.Forms.ComboBox();
            this.comboClasificador = new System.Windows.Forms.ComboBox();
            this.comboSubClasi = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remitente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asunto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Clasificador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Subclasificador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Seleccione archivo";
            // 
            // ArchivoBtn
            // 
            this.ArchivoBtn.Location = new System.Drawing.Point(92, 288);
            this.ArchivoBtn.Name = "ArchivoBtn";
            this.ArchivoBtn.Size = new System.Drawing.Size(75, 23);
            this.ArchivoBtn.TabIndex = 7;
            this.ArchivoBtn.Text = "Seleccionar Archivo";
            this.ArchivoBtn.UseVisualStyleBackColor = true;
            this.ArchivoBtn.Click += new System.EventHandler(this.ArchivoBtn_Click);
            // 
            // RemitenteTxt
            // 
            this.RemitenteTxt.Location = new System.Drawing.Point(199, 22);
            this.RemitenteTxt.Name = "RemitenteTxt";
            this.RemitenteTxt.Size = new System.Drawing.Size(100, 20);
            this.RemitenteTxt.TabIndex = 8;
            // 
            // AsuntoTxt
            // 
            this.AsuntoTxt.Location = new System.Drawing.Point(199, 51);
            this.AsuntoTxt.Name = "AsuntoTxt";
            this.AsuntoTxt.Size = new System.Drawing.Size(100, 20);
            this.AsuntoTxt.TabIndex = 9;
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(199, 84);
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(100, 20);
            this.DescripcionTxt.TabIndex = 10;
            this.DescripcionTxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Rutalbl
            // 
            this.Rutalbl.AutoSize = true;
            this.Rutalbl.Location = new System.Drawing.Point(199, 260);
            this.Rutalbl.Name = "Rutalbl";
            this.Rutalbl.Size = new System.Drawing.Size(35, 13);
            this.Rutalbl.TabIndex = 14;
            this.Rutalbl.Text = "label8";
            // 
            // SubirArchivoBtn
            // 
            this.SubirArchivoBtn.Location = new System.Drawing.Point(202, 288);
            this.SubirArchivoBtn.Name = "SubirArchivoBtn";
            this.SubirArchivoBtn.Size = new System.Drawing.Size(75, 23);
            this.SubirArchivoBtn.TabIndex = 15;
            this.SubirArchivoBtn.Text = "Enviar";
            this.SubirArchivoBtn.UseVisualStyleBackColor = true;
            this.SubirArchivoBtn.Click += new System.EventHandler(this.SubirArchivoBtn_Click);
            // 
            // comboArea
            // 
            this.comboArea.FormattingEnabled = true;
            this.comboArea.Location = new System.Drawing.Point(199, 132);
            this.comboArea.Name = "comboArea";
            this.comboArea.Size = new System.Drawing.Size(121, 21);
            this.comboArea.TabIndex = 16;
            // 
            // comboClasificador
            // 
            this.comboClasificador.FormattingEnabled = true;
            this.comboClasificador.Location = new System.Drawing.Point(199, 159);
            this.comboClasificador.Name = "comboClasificador";
            this.comboClasificador.Size = new System.Drawing.Size(121, 21);
            this.comboClasificador.TabIndex = 17;
            this.comboClasificador.SelectedIndexChanged += new System.EventHandler(this.comboClasificador_SelectedIndexChanged);
            // 
            // comboSubClasi
            // 
            this.comboSubClasi.FormattingEnabled = true;
            this.comboSubClasi.Location = new System.Drawing.Point(199, 191);
            this.comboSubClasi.Name = "comboSubClasi";
            this.comboSubClasi.Size = new System.Drawing.Size(121, 21);
            this.comboSubClasi.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 236);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Copia para";
            // 
            // Registro_Documentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboSubClasi);
            this.Controls.Add(this.comboClasificador);
            this.Controls.Add(this.comboArea);
            this.Controls.Add(this.SubirArchivoBtn);
            this.Controls.Add(this.Rutalbl);
            this.Controls.Add(this.DescripcionTxt);
            this.Controls.Add(this.AsuntoTxt);
            this.Controls.Add(this.RemitenteTxt);
            this.Controls.Add(this.ArchivoBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registro_Documentos";
            this.Text = "Registro_Documentos";
            this.Load += new System.EventHandler(this.Registro_Documentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ArchivoBtn;
        private System.Windows.Forms.TextBox RemitenteTxt;
        private System.Windows.Forms.TextBox AsuntoTxt;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.Label Rutalbl;
        private System.Windows.Forms.Button SubirArchivoBtn;
        private System.Windows.Forms.ComboBox comboArea;
        private System.Windows.Forms.ComboBox comboClasificador;
        private System.Windows.Forms.ComboBox comboSubClasi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
    }
}