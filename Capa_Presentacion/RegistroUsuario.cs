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
    public partial class RegistroUsuario : Form
    {
        CN_Usuarios cnUsuarios = new CN_Usuarios();
        string datoOrig;

        public RegistroUsuario()
        {
            InitializeComponent();
        }

        public void CargarAreas()
        {
            DataTable ar = cnUsuarios.CargarAreas();
            for (int i = 0; i < ar.Rows.Count; i++)
            {
                cmbAre.Items.Add(ar.Rows[i]["Descripcion"]);
            }
        }
        public void CargarRoles()
        {
            DataTable ro = cnUsuarios.CargarRol();
            for (int i = 0; i < ro.Rows.Count; i++)
            {
                cmbRol.Items.Add(ro.Rows[i]["Rol"]);
            }
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            CargarAreas();
            CargarRoles();
            tableUsers.DataSource = cnUsuarios.tablaUsuarios();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            cnUsuarios.RegistrarUsuario(txtNom.Text, txtApe.Text, txtUsu.Text, txtCla.Text, txtTel.Text, txtCorr.Text, cmbAre.Text, cmbRol.Text);
            MessageBox.Show("Usuario Registrado");
            tableUsers.DataSource = cnUsuarios.tablaUsuarios();
            Limpiar();
        }

        public void Limpiar()
        {
            txtNom.Text = "";
            txtApe.Text = "";
            txtUsu.Text = "";
            txtCla.Text = "";
            txtTel.Text = "";
            txtCorr.Text = "";
            cmbAre.Text = "";
            cmbRol.Text = "";
        }

        private void tableUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            datoOrig = tableUsers.CurrentRow.Cells[2].Value.ToString();
            txtNom.Text = tableUsers.CurrentRow.Cells[0].Value.ToString();
            txtApe.Text = tableUsers.CurrentRow.Cells[1].Value.ToString();
            txtUsu.Text = tableUsers.CurrentRow.Cells[2].Value.ToString();
            txtCla.Text = tableUsers.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = tableUsers.CurrentRow.Cells[4].Value.ToString();
            txtCorr.Text = tableUsers.CurrentRow.Cells[5].Value.ToString();
            cmbAre.SelectedItem= tableUsers.CurrentRow.Cells[6].Value.ToString();
            cmbRol.SelectedItem = tableUsers.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            cnUsuarios.ModificarUsuario(datoOrig, txtNom.Text, txtApe.Text, txtUsu.Text, txtCla.Text, txtTel.Text, txtCorr.Text, cmbAre.Text, cmbRol.Text);
            MessageBox.Show("Usuario Actaulizado");
            tableUsers.DataSource = cnUsuarios.tablaUsuarios();
            Limpiar();
        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            cnUsuarios.EliminarUsuario(txtUsu.Text);
            MessageBox.Show("Usuario Eliminado");
            tableUsers.DataSource = cnUsuarios.tablaUsuarios();
            Limpiar();
        }
    }
}
