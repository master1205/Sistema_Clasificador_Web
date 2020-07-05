using Capa_Negocio;
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
    public partial class RegistroSubclasificador : Form
    {
        CN_SubClasificadores cnSubClasificador = new CN_SubClasificadores();
        string clasi, subClas;
        public RegistroSubclasificador()
        {
            InitializeComponent();
        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            cnSubClasificador.EliminarSubClasificador(txtDes.Text);
            tableClasi.DataSource = cnSubClasificador.tablaSubC();
            txtDes.Text = "";
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cnSubClasificador.RegistrarSubClasificador(" + cmbSub.Text + ", " + txtDes.Text + ");");
            cnSubClasificador.RegistrarSubClasificador(cmbSub.Text, txtDes.Text);
            
            tableClasi.DataSource = cnSubClasificador.tablaSubC();
            txtDes.Text = "";
        }

        private void tableClasi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            subClas = tableClasi.CurrentRow.Cells[0].Value.ToString();
            txtDes.Text = tableClasi.CurrentRow.Cells[1].Value.ToString();
        }

        private void RegistroSubclasificador_Load(object sender, EventArgs e)
        {
            CargarClasificadores();
            tableClasi.DataSource = cnSubClasificador.tablaSubC();
        }

        public void CargarClasificadores()
        {
            DataTable ar = cnSubClasificador.CargarClasificadores();
            for (int i = 0; i < ar.Rows.Count; i++)
            {
                cmbSub.Items.Add(ar.Rows[i]["Descripcion"]);
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            cnSubClasificador.ModificarSubClasificador(subClas, txtDes.Text);
            tableClasi.DataSource = cnSubClasificador.tablaSubC();
            txtDes.Text = "";
        }
    }
}
