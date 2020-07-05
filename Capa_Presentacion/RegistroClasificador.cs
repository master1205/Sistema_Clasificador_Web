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
    public partial class RegistroClasificador : Form
    {
        CN_Clasificadores cnClasificador = new CN_Clasificadores();
        string orig;

        public RegistroClasificador()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            cnClasificador.RegistrarClasificador(txtDes.Text);
            tableClasi.DataSource = cnClasificador.tablaUsuarios();
            txtDes.Text = "";
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            cnClasificador.ModificarClasificador(orig, txtDes.Text);
            tableClasi.DataSource = cnClasificador.tablaUsuarios();
            txtDes.Text = "";
        }

        private void tableClasi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            orig= tableClasi.CurrentRow.Cells[0].Value.ToString();
            txtDes.Text= tableClasi.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            cnClasificador.EliminarClasificador(txtDes.Text);
            tableClasi.DataSource = cnClasificador.tablaUsuarios();
            txtDes.Text = "";
        }

        private void RegistroClasificador_Load(object sender, EventArgs e)
        {
            tableClasi.DataSource = cnClasificador.tablaUsuarios();
        }
    }
}
