using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Pantalla_Administrador : Form
    {
        public Pantalla_Administrador()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<Forms>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                //formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                //si la Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();
            }
        }

        private void registrarDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Consulta_Documentos>();
        }
    }
}
