using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Capa_Presentacion
{
    public partial class Registro_Areas : Form
    {
        CN_Areas cnAreas = new CN_Areas();
        public Registro_Areas()
        {
            InitializeComponent();
        }

        public void muestraTabla() {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cnAreas.tablaAreas();
        }

        private void Registro_Areas_Load(object sender, EventArgs e)
        {
            muestraTabla();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            string descripcion = DescripcionTxt.Text;
            cnAreas.insertarArea(descripcion);
            muestraTabla();
            MessageBox.Show("Agregado");
        }
    }
}
