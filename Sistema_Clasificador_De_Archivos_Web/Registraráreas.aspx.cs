using Capa_Negocio;
using System;
using System.Configuration;
using System.Drawing;
using System.Web;
using System.Web.UI.WebControls;

namespace Sistema_Clasificador_De_Archivos_Web.Classes
{
    public partial class Registraráreas : System.Web.UI.Page
    {
        private string cadena = "";
        private static int y;
        private string orig;
        CN_Areas cnAreas = new CN_Areas();
        protected void Page_Load(object sender, EventArgs e)
        {
            cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
            muestraTabla();
        }

        protected void VistaAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            y = 1;
            foreach (GridViewRow row in VistaAreas.Rows)
            {
                if (row.RowIndex == VistaAreas.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#1CD1D4"); ;
                    row.ToolTip = string.Empty;
                }
                else
                {
                    row.BackColor = Color.White;
                }
            }
            orig = VistaAreas.SelectedRow.Cells[1].Text;
            txtArea.Text = HttpUtility.HtmlDecode(VistaAreas.SelectedRow.Cells[2].Text);
        }
        public void muestraTabla()
        {
            VistaAreas.DataSource = cnAreas.tablaAreas();
            VistaAreas.DataBind();
        }

        protected void btnRegistra_Click(object sender, EventArgs e)
        {
            if (y == 1)
            {
                cnAreas.modificarArea(VistaAreas.SelectedRow.Cells[1].Text, txtArea.Text);
                muestraTabla();
                txtArea.Text = "";
                y = 0;
            }
            else if (y == 0)
            {
                string descripcion = txtArea.Text;
                cnAreas.insertarArea(descripcion);
                muestraTabla();
                txtArea.Text = "";
                y = 0;
            }
        }
    }
}