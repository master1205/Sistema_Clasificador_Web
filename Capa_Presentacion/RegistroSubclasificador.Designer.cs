namespace Capa_Presentacion
{
    partial class RegistroSubclasificador
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
            this.txtDes = new System.Windows.Forms.TextBox();
            this.btnEli = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.tableClasi = new System.Windows.Forms.DataGridView();
            this.cmbSub = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableClasi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Descripción:";
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(110, 157);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(130, 20);
            this.txtDes.TabIndex = 30;
            // 
            // btnEli
            // 
            this.btnEli.Location = new System.Drawing.Point(548, 292);
            this.btnEli.Name = "btnEli";
            this.btnEli.Size = new System.Drawing.Size(75, 23);
            this.btnEli.TabIndex = 29;
            this.btnEli.Text = "Eliminar";
            this.btnEli.UseVisualStyleBackColor = true;
            this.btnEli.Click += new System.EventHandler(this.btnEli_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(455, 292);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 28;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(364, 292);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 27;
            this.btnReg.Text = "Registrar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // tableClasi
            // 
            this.tableClasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableClasi.Location = new System.Drawing.Point(281, 91);
            this.tableClasi.Name = "tableClasi";
            this.tableClasi.Size = new System.Drawing.Size(479, 150);
            this.tableClasi.TabIndex = 26;
            this.tableClasi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableClasi_CellMouseClick);
            // 
            // cmbSub
            // 
            this.cmbSub.FormattingEnabled = true;
            this.cmbSub.Location = new System.Drawing.Point(41, 118);
            this.cmbSub.Name = "cmbSub";
            this.cmbSub.Size = new System.Drawing.Size(153, 21);
            this.cmbSub.TabIndex = 32;
            // 
            // RegistroSubclasificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbSub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.btnEli);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.tableClasi);
            this.Name = "RegistroSubclasificador";
            this.Text = "RegistroSubclasificador";
            this.Load += new System.EventHandler(this.RegistroSubclasificador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableClasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Button btnEli;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.DataGridView tableClasi;
        private System.Windows.Forms.ComboBox cmbSub;
    }
}