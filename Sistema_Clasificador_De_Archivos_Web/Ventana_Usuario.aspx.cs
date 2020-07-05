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
using Capa_Entidades;
using System.Drawing;

namespace Sistema_Clasificador_De_Archivos_Web
{
    public partial class Ventana_Usuario : System.Web.UI.Page
    {
        CN_Documentos cnDoc = new CN_Documentos();
        CE_Archivos_Google archivos = new CE_Archivos_Google();
        string Cadena = "";
        public static int numero;
        public static string rol;
        protected void Page_Load(object sender, EventArgs e)
        {
            Cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
            tablaDocumentos2();
        }
        public void tablaDocumentos2()
        {
            vistaDocumentos.DataSource = cnDoc.tablaDocumentos2(numero);
            vistaDocumentos.DataBind();
        }
        public void mostarest(string estado)
        {
                vistaDocumentos.DataSource = cnDoc.tablaEstado2(estado, numero);
                vistaDocumentos.DataBind();
        }

        protected void btnTodos_Click(object sender, EventArgs e)
        {
                vistaDocumentos.DataSource = cnDoc.consultaGeneral(numero);
                vistaDocumentos.DataBind();
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
            using (SqlConnection conexion = new SqlConnection(Cadena))
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

        protected void btnAceptados_Click(object sender, EventArgs e)
        {
            mostarest("2");
            
        }

        protected void btnProgreso_Click(object sender, EventArgs e)
        {
           mostarest("1");
        }
        //boton aceptar
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = "";
                foreach (GridViewRow row in vistaDocumentos.Rows)
                {
                    nombre = row.Cells[1].Text;
                }
                cnDoc.aceptarDocumento(vistaDocumentos.SelectedRow.Cells[1].Text);
                tablaDocumentos2();
            }
            catch (Exception ss)
            {
            }
        }
        //boton rechazar
        protected void Button4_Click(object sender, EventArgs e)
        {
            string nombre = "";
            foreach (GridViewRow row in vistaDocumentos.Rows)
            {
                nombre = row.Cells[1].Text;
            }
            cnDoc.rechazarDocumento(vistaDocumentos.SelectedRow.Cells[1].Text);
            tablaDocumentos2();
        }
        //boton descargar
        protected void Button6_Click(object sender, EventArgs e)
        {
            string nombre = "";
            foreach (GridViewRow row in vistaDocumentos.Rows)
            {
                nombre = row.Cells[1].Text;
            }
            SqlDataReader dr = cnDoc.descargarDocumento(nombre);
            string codigo = "";
            while (dr.Read() == true)
            {
                codigo = dr.GetString(0);
            }
            archivos.descargarArc(nombre, codigo);
        }
        
        protected void vistaDocumentos_RowDeleted1(object sender, GridViewDeletedEventArgs e)
        {

            string nombre1 = vistaDocumentos.SelectedRow.Cells[12].Text;
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
            tablaDocumentos2();
        
    }

        protected void vistaDocumentos_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            string nombre2 = vistaDocumentos.SelectedRow.Cells[12].Text;
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
            tablaDocumentos2();
        }

        protected void vistaDocumentos_SelectedIndexChanged1(object sender, EventArgs e)
        {

            string nombre = vistaDocumentos.SelectedRow.Cells[12].Text;
            string codigo = vistaDocumentos.SelectedRow.Cells[11].Text;
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
    }
}