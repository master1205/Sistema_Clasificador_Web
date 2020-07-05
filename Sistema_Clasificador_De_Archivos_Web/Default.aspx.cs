using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Clasificador_De_Archivos_Web
{
    public partial class _Default : Page
    {
        private string cadena = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        }

        protected void Acceder_btn_Click(object sender, EventArgs e)
        {

            if (UsuarioTxt.Text.Trim() == "")
            {
                UsuarioTxt.Focus();
            }
            else if (ClaveTxt.Text.Trim() == "")
            {
                ClaveTxt.Focus();
            }
            string usuario = UsuarioTxt.Text;
            string clave = ClaveTxt.Text;
            CN_InicioSesion inic = new CN_InicioSesion();
            SqlDataReader dr = inic.inicioSesion(usuario, clave);
            if (dr.Read() == true)
            {
                string rol = dr.GetString(2);
                int area = dr.GetInt32(3);
                Ventana_Usuario.rol = rol;
                Ventana_Usuario.numero = area;
                if (rol.Equals("Administrador"))
                {
                    Response.Redirect("Ventana_Administrador.aspx");
                }
                else if (rol.Equals("Administrativo"))
                {
                    Response.Redirect("Administrativo.aspx");
                }
                else
                {
                    Response.Redirect("Ventana_Usuario.aspx");
                }

            }
            else
            {
                //Errores.Text = "No hay registros";
            }
        }
    }
}