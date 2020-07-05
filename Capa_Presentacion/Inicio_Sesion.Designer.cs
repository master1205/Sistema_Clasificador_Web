namespace Capa_Presentacion
{
    partial class Inicio_Sesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.UsuarioTxt = new System.Windows.Forms.TextBox();
            this.ClaveTxt = new System.Windows.Forms.TextBox();
            this.AccederBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // UsuarioTxt
            // 
            this.UsuarioTxt.Location = new System.Drawing.Point(210, 34);
            this.UsuarioTxt.Name = "UsuarioTxt";
            this.UsuarioTxt.Size = new System.Drawing.Size(100, 20);
            this.UsuarioTxt.TabIndex = 2;
            // 
            // ClaveTxt
            // 
            this.ClaveTxt.Location = new System.Drawing.Point(210, 80);
            this.ClaveTxt.Name = "ClaveTxt";
            this.ClaveTxt.Size = new System.Drawing.Size(100, 20);
            this.ClaveTxt.TabIndex = 3;
            // 
            // AccederBtn
            // 
            this.AccederBtn.Location = new System.Drawing.Point(210, 186);
            this.AccederBtn.Name = "AccederBtn";
            this.AccederBtn.Size = new System.Drawing.Size(75, 23);
            this.AccederBtn.TabIndex = 4;
            this.AccederBtn.Text = "Acceder";
            this.AccederBtn.UseVisualStyleBackColor = true;
            this.AccederBtn.Click += new System.EventHandler(this.AccederBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clave";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 243);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AccederBtn);
            this.Controls.Add(this.ClaveTxt);
            this.Controls.Add(this.UsuarioTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsuarioTxt;
        private System.Windows.Forms.TextBox ClaveTxt;
        private System.Windows.Forms.Button AccederBtn;
        private System.Windows.Forms.Label label2;
    }
}

