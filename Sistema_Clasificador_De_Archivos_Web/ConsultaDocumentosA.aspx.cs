using Capa_Entidades;
using Google.Apis.Drive.v3;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Negocio;
namespace Sistema_Clasificador_De_Archivos_Web
{
    public partial class ConsultaDocumentosA : System.Web.UI.Page
    {

        private static string[] Scopes = { DriveService.Scope.Drive };
        private static string aplicacionNombre = "GoogleAPIStart";
        private static string _downloadFilePath = @"C:\Users\MarioBrosPlus\Downloads";
        private string cadena = "";
        private static string codigo = "";
        private static string nombre = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
            Documentos();
        }
        public void Documentos()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                try
                {
                    string query = "select * from Documento";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    if (data.Tables[0].Rows.Count > 0)
                    {
                        vistaDocumentos.DataSource = data;
                        vistaDocumentos.DataBind();
                        Error.Visible = false;
                    }
                    else
                    {
                        Error.Text = "No hay Archivos";
                    }
                }
                catch (Exception ex)
                {
                    Error.Text = "Error: " + ex;
                }
            }
        }

        protected void vistaDocumentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombre = vistaDocumentos.SelectedRow.Cells[12].Text;
            codigo = vistaDocumentos.SelectedRow.Cells[11].Text;
            foreach (GridViewRow row in vistaDocumentos.Rows)
            {
                if (row.RowIndex == vistaDocumentos.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#1C83DC"); ;
                    row.ToolTip = string.Empty;
                }
                else
                {
                    row.BackColor = Color.White;
                }

            }
            CE_Archivos_Google ce = new CE_Archivos_Google();
            ce.descargarArc(nombre, codigo);
        }

        protected void vistaDocumentos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Attributes["oneclick"] = Page.ClientScript.GetPostBackClientHyperlink(vistaDocumentos, "Select$" + e.Row.RowIndex);
        }

        protected void btnBuscaState_Click(object sender, EventArgs e)
        {
            string query = "";
            switch (Drop1.SelectedValue)
            {
                case "Registrados":
                    query = "select * from Documento where Estado='1'";
                    break;
                case "Todos":
                    query = "select * from Documento";
                    break;
                case "Aceptados":
                    query = "select * from Documento where Estado='2'";
                    break;
                case "Rechazados":
                    query = "select * from Documento where Estado='3'";
                    break;
                default:
                    vistaDocumentos.Visible = false;
                    Error.Text = "No hay Archivos";
                    break;
            }
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    if (data.Tables[0].Rows.Count > 0)
                    {
                        vistaDocumentos.Visible = true;
                        vistaDocumentos.DataSource = data;
                        vistaDocumentos.DataBind();
                    }
                    else
                    {
                        Error.Text = "No hay Archivos";
                    }
                }
                catch (Exception ex)
                {
                    Error.Text = "Error: " + ex;
                }
            }
        }

        protected void btnDescargar_Click(object sender, EventArgs e)
        {
            CE_Archivos_Google ce = new CE_Archivos_Google();
            ce.descargarArc(nombre,codigo);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
        }

        protected void vistaDocumentos_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            string nombre1 = vistaDocumentos.SelectedRow.Cells[12].Text;
            codigo = vistaDocumentos.SelectedRow.Cells[11].Text;
            foreach (GridViewRow row in vistaDocumentos.Rows)
            {
                if (row.RowIndex == vistaDocumentos.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#1C83DC"); ;
                    row.ToolTip = string.Empty;
                }
                else
                {
                    row.BackColor = Color.White;
                }

            }
            CN_Documentos cn = new CN_Documentos();
            cn.rechazarDocumento(nombre1);
            Documentos();
        }

        protected void vistaDocumentos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string nombre2 = vistaDocumentos.SelectedRow.Cells[12].Text;
            codigo = vistaDocumentos.SelectedRow.Cells[11].Text;
            foreach (GridViewRow row in vistaDocumentos.Rows)
            {
                if (row.RowIndex == vistaDocumentos.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#1C83DC"); ;
                    row.ToolTip = string.Empty;
                }
                else
                {
                    row.BackColor = Color.White;
                }

            }
            CN_Documentos cn = new CN_Documentos();
            cn.aceptarDocumento(nombre2);
            Documentos();
        }
    }
}