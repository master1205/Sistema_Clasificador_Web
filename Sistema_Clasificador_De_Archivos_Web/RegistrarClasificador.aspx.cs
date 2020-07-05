using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Capa_Negocio;
using System.Drawing;

namespace Sistema_Clasificador_De_Archivos_Web
{
    
    public partial class RegistrarClasificador : System.Web.UI.Page
    {

        CN_Clasificadores cnClasificador = new CN_Clasificadores();
        string orig;
        public static int y;
        private string cadena="";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
                cargarTabla();
            }
        }
        protected void VistaClasificador_SelectedIndexChanged(object sender, EventArgs e)
        {
            y = 1;
            orig = HttpUtility.HtmlDecode(VistaClasificador.SelectedRow.Cells[1].Text);
            clasificadorTxt.Text= HttpUtility.HtmlDecode(VistaClasificador.SelectedRow.Cells[2].Text);
            foreach (GridViewRow row in VistaClasificador.Rows)
            {
                if (row.RowIndex == VistaClasificador.SelectedIndex)
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

        protected void btnRegistra_Click(object sender, EventArgs e)
        {
            if (y == 1)
            {
                //modifica
                cnClasificador.ModificarClasificador(VistaClasificador.SelectedRow.Cells[1].Text, clasificadorTxt.Text);
                VistaClasificador.DataSource = cnClasificador.tablaUsuarios();                
                cargarTabla();
                y = 0;
                clasificadorTxt.Text = "";
            }
            else {
                //inserta
                cnClasificador.RegistrarClasificador(clasificadorTxt.Text);
                VistaClasificador.DataSource = cnClasificador.tablaUsuarios();                
                cargarTabla();
                y = 0;
                clasificadorTxt.Text = "";
            }
        }
        public void cargarTabla() {
            VistaClasificador.DataSource = cnClasificador.tablaUsuarios();
            VistaClasificador.DataBind();
        }
    }
}