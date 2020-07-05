using Capa_Negocio;
using System;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.UI.WebControls;
namespace Sistema_Clasificador_De_Archivos_Web
{
    public partial class RegistrarSubClasificador : System.Web.UI.Page
    {
        CN_SubClasificadores cnSubClasificador = new CN_SubClasificadores();
        private static int y = 0;
        string orig;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarClasificadores();
                CargarTabla();
            }
        }
        public void CargarTabla()
        {
            VistaSubClasificador.DataSource = cnSubClasificador.tablaSubC();
            VistaSubClasificador.DataBind();
        }
        public void CargarClasificadores()
        {
            DropClasificador.DataSource = cnSubClasificador.CargarClasificadores();
            DropClasificador.DataValueField = "Descripcion";
            DropClasificador.DataBind();
            DropClasificador.Items.Insert(0, new ListItem("Seleccionar"));
        }

        protected void VistaSubClasificador_SelectedIndexChanged(object sender, EventArgs e)
        {
            y = 1;
            foreach (GridViewRow row in VistaSubClasificador.Rows)
            {
                if (row.RowIndex == VistaSubClasificador.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#1CD1D4"); ;
                    row.ToolTip = string.Empty;
                }
                else
                {
                    row.BackColor = Color.White;
                }
            }
            DropClasificador.SelectedItem.Text= HttpUtility.HtmlDecode(VistaSubClasificador.SelectedRow.Cells[1].Text);
            DescripcionTxt.Text = HttpUtility.HtmlDecode(VistaSubClasificador.SelectedRow.Cells[2].Text);
            DropClasificador.Enabled = false;
        }

        protected void btnRegistra_Click(object sender, EventArgs e)
        {
            if (y == 1)
            {
                //modifica
                cnSubClasificador.ModificarSubClasificador(DropClasificador.SelectedItem.Text, DescripcionTxt.Text);
                VistaSubClasificador.DataSource = cnSubClasificador.tablaSubC();
                DescripcionTxt.Text = "";
                CargarTabla();
                DropClasificador.Items.Clear();
                CargarClasificadores();
                y = 0;

            }
            else
            {
                //agrega
                string cla = "";
                string combo = DropClasificador.SelectedItem.ToString();
                DataTable ar2 = cnSubClasificador.obtenerIDClasificador(combo);
                for (int i = 0; i < ar2.Rows.Count; i++)
                {
                    cla = (ar2.Rows[i]["Clasificador"].ToString());
                }
                cnSubClasificador.RegistrarSubClasificador(cla, DescripcionTxt.Text);
                VistaSubClasificador.DataSource = cnSubClasificador.tablaSubC();
                DescripcionTxt.Text = "";
                CargarTabla();
                DropClasificador.Items.Clear();
                CargarClasificadores();
                y = 0;

            }
            DropClasificador.Enabled = true;
        }
    }
}