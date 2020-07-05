namespace Capa_Presentacion
{
    partial class Consulta_Documentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Documentos));
            this.DocumentosView = new System.Windows.Forms.DataGridView();
            this.RegistrosAceptadosBtn = new System.Windows.Forms.Button();
            this.RechazarBtn = new System.Windows.Forms.Button();
            this.DescargarBtn = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ProgresoBtn = new System.Windows.Forms.Button();
            this.TodosBtn = new System.Windows.Forms.Button();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.RechazarDocumentoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentosView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // DocumentosView
            // 
            this.DocumentosView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DocumentosView.Location = new System.Drawing.Point(35, 67);
            this.DocumentosView.Name = "DocumentosView";
            this.DocumentosView.Size = new System.Drawing.Size(481, 269);
            this.DocumentosView.TabIndex = 0;
            // 
            // RegistrosAceptadosBtn
            // 
            this.RegistrosAceptadosBtn.Location = new System.Drawing.Point(35, 36);
            this.RegistrosAceptadosBtn.Name = "RegistrosAceptadosBtn";
            this.RegistrosAceptadosBtn.Size = new System.Drawing.Size(105, 27);
            this.RegistrosAceptadosBtn.TabIndex = 1;
            this.RegistrosAceptadosBtn.Text = "Aceptados";
            this.RegistrosAceptadosBtn.UseVisualStyleBackColor = true;
            this.RegistrosAceptadosBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // RechazarBtn
            // 
            this.RechazarBtn.Location = new System.Drawing.Point(338, 32);
            this.RechazarBtn.Name = "RechazarBtn";
            this.RechazarBtn.Size = new System.Drawing.Size(105, 27);
            this.RechazarBtn.TabIndex = 2;
            this.RechazarBtn.Text = "Rechazados";
            this.RechazarBtn.UseVisualStyleBackColor = true;
            this.RechazarBtn.Click += new System.EventHandler(this.RechazarBtn_Click);
            // 
            // DescargarBtn
            // 
            this.DescargarBtn.Location = new System.Drawing.Point(550, 165);
            this.DescargarBtn.Name = "DescargarBtn";
            this.DescargarBtn.Size = new System.Drawing.Size(105, 27);
            this.DescargarBtn.TabIndex = 3;
            this.DescargarBtn.Text = "Descargar";
            this.DescargarBtn.UseVisualStyleBackColor = true;
            this.DescargarBtn.Click += new System.EventHandler(this.DescargarBtn_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(719, 12);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(260, 413);
            this.axAcroPDF1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ProgresoBtn
            // 
            this.ProgresoBtn.Location = new System.Drawing.Point(227, 36);
            this.ProgresoBtn.Name = "ProgresoBtn";
            this.ProgresoBtn.Size = new System.Drawing.Size(105, 23);
            this.ProgresoBtn.TabIndex = 6;
            this.ProgresoBtn.Text = "Progreso";
            this.ProgresoBtn.UseVisualStyleBackColor = true;
            this.ProgresoBtn.Click += new System.EventHandler(this.ProgresoBtn_Click);
            // 
            // TodosBtn
            // 
            this.TodosBtn.Location = new System.Drawing.Point(146, 36);
            this.TodosBtn.Name = "TodosBtn";
            this.TodosBtn.Size = new System.Drawing.Size(75, 23);
            this.TodosBtn.TabIndex = 7;
            this.TodosBtn.Text = "Todos";
            this.TodosBtn.UseVisualStyleBackColor = true;
            this.TodosBtn.Click += new System.EventHandler(this.TodosBtn_Click);
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(550, 85);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(105, 23);
            this.AceptarBtn.TabIndex = 9;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click_1);
            // 
            // RechazarDocumentoBtn
            // 
            this.RechazarDocumentoBtn.Location = new System.Drawing.Point(550, 131);
            this.RechazarDocumentoBtn.Name = "RechazarDocumentoBtn";
            this.RechazarDocumentoBtn.Size = new System.Drawing.Size(105, 23);
            this.RechazarDocumentoBtn.TabIndex = 10;
            this.RechazarDocumentoBtn.Text = "Rechazar";
            this.RechazarDocumentoBtn.UseVisualStyleBackColor = true;
            this.RechazarDocumentoBtn.Click += new System.EventHandler(this.RechazarDocumentoBtn_Click);
            // 
            // Consulta_Documentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.RechazarDocumentoBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.TodosBtn);
            this.Controls.Add(this.ProgresoBtn);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.DescargarBtn);
            this.Controls.Add(this.RechazarBtn);
            this.Controls.Add(this.RegistrosAceptadosBtn);
            this.Controls.Add(this.DocumentosView);
            this.Name = "Consulta_Documentos";
            this.Text = "Consulta_Documentos";
            this.Load += new System.EventHandler(this.Consulta_Documentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DocumentosView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DocumentosView;
        private System.Windows.Forms.Button RegistrosAceptadosBtn;
        private System.Windows.Forms.Button RechazarBtn;
        private System.Windows.Forms.Button DescargarBtn;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button ProgresoBtn;
        private System.Windows.Forms.Button TodosBtn;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Button RechazarDocumentoBtn;
    }
}