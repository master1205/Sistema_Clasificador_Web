using Capa_Negocio;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Sistema_Clasificador_De_Archivos_Web
{
    public partial class Inicio_Sesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Accederbtn_Click(object sender, EventArgs e)
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
                string usuario1 = dr.GetString(1);
                int area = dr.GetInt32(3);
                Ventana_Usuario.rol = rol;
                Ventana_Usuario.numero = area;
                switch (rol)
                {
                    case "Administrador":
                        Response.Redirect("Ventana_Administrador.aspx");
                        break;
                    case "Responsable de área":
                        Ventana_Usuario.numero = area;
                        Response.Redirect("Ventana_Usuario.aspx");
                        break;
                    case "Administrativo":
                        Administrativo.nombre = usuario1;
                        Response.Redirect("Administrativo.aspx");
                        break;
                    default:
                        break;
                }

            }
            else
            {
                //Errores.Text = "No hay registros";
            }
        }
    }
}