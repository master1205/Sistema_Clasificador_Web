using Capa_Negocio;
using System;
using Capa_Entidades;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Sistema_Clasificador_De_Archivos_Web
{
    public partial class Administrativo : System.Web.UI.Page
    {
        CN_Copia copia = new CN_Copia();
        public static string nombre;
        private string nomb="",codigo="";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla();
            }
        }
        public void CargarTabla()
        {
            vistaDocumentos.DataSource = copia.tablaCopias(nombre);
            vistaDocumentos.DataBind();
        }

        protected void btnRegistra_Click(object sender, EventArgs e)
        {
            CE_Archivos_Google ce = new CE_Archivos_Google();
            ce.descargarArc(vistaDocumentos.SelectedRow.Cells[6].Text, vistaDocumentos.SelectedRow.Cells[7].Text);
        }

        protected void vistaDocumentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in vistaDocumentos.Rows)
            {
                if (row.RowIndex == vistaDocumentos.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#1CD1D4"); ;
                    row.ToolTip = string.Empty;
                }
                else
                {
                    row.BackColor = Color.White;
                }
            }
        }
    }
}