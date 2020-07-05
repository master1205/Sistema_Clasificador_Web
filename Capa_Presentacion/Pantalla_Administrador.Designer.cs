namespace Capa_Presentacion
{
    partial class Pantalla_Administrador
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDocumentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDocumentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subclasificadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.documentosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAreaToolStripMenuItem,
            this.registrarUsuariosToolStripMenuItem,
            this.clasificadorToolStripMenuItem,
            this.subclasificadoresToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(181, 20);
            this.registrosToolStripMenuItem.Text = "Registros                                      ";
            // 
            // documentosToolStripMenuItem
            // 
            this.documentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarDocumentosToolStripMenuItem,
            this.consultarDocumentosToolStripMenuItem});
            this.documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            this.documentosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.documentosToolStripMenuItem.Text = "Documentos";
            // 
            // registrarDocumentosToolStripMenuItem
            // 
            this.registrarDocumentosToolStripMenuItem.Name = "registrarDocumentosToolStripMenuItem";
            this.registrarDocumentosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.registrarDocumentosToolStripMenuItem.Text = "Registrar Documentos";
            this.registrarDocumentosToolStripMenuItem.Click += new System.EventHandler(this.registrarDocumentosToolStripMenuItem_Click);
            // 
            // consultarDocumentosToolStripMenuItem
            // 
            this.consultarDocumentosToolStripMenuItem.Name = "consultarDocumentosToolStripMenuItem";
            this.consultarDocumentosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.consultarDocumentosToolStripMenuItem.Text = "Consultar Documentos";
            // 
            // registrarAreaToolStripMenuItem
            // 
            this.registrarAreaToolStripMenuItem.Name = "registrarAreaToolStripMenuItem";
            this.registrarAreaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarAreaToolStripMenuItem.Text = "Áreas";
            // 
            // registrarUsuariosToolStripMenuItem
            // 
            this.registrarUsuariosToolStripMenuItem.Name = "registrarUsuariosToolStripMenuItem";
            this.registrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarUsuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // clasificadorToolStripMenuItem
            // 
            this.clasificadorToolStripMenuItem.Name = "clasificadorToolStripMenuItem";
            this.clasificadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clasificadorToolStripMenuItem.Text = "Clasificador";
            // 
            // subclasificadoresToolStripMenuItem
            // 
            this.subclasificadoresToolStripMenuItem.Name = "subclasificadoresToolStripMenuItem";
            this.subclasificadoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subclasificadoresToolStripMenuItem.Text = "Subclasificadores";
            // 
            // panelFormularios
            // 
            this.panelFormularios.Location = new System.Drawing.Point(0, 27);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(859, 453);
            this.panelFormularios.TabIndex = 1;
            // 
            // Pantalla_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 477);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pantalla_Administrador";
            this.Text = "Pantalla_Administrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasificadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subclasificadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarDocumentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarDocumentosToolStripMenuItem;
        private System.Windows.Forms.Panel panelFormularios;
    }
}