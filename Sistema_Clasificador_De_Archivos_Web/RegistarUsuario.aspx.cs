using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI.WebControls;
using System.Drawing;
using Capa_Negocio;

namespace Sistema_Clasificador_De_Archivos_Web
{
    public partial class RegistarUsuario : System.Web.UI.Page
    {
        CN_Usuarios cnUsuarios = new CN_Usuarios();
        private string cadena = "";
        private static int y;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UsuarioTxtx.Text = "";
                ContraseñaTxt.Text = "";
                cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
                Usuario();
                Area();
                Rol();
            }
        }
        public void Usuario()
        {
            VistaUsuarios.DataSource = cnUsuarios.tablaUsuarios();
            VistaUsuarios.DataBind();
            UsuarioTxtx.Text = "";
            NombreTxt.Text = "";
            ApellidosTxt.Text = "";
            ContraseñaTxt.Text = "";
            TelefonoTxt.Text = "";
            CorreoTxt.Text = "";
            ComboArea.SelectedIndex = 0;
            ComboRol.SelectedIndex = 0;
        }
        public void Area()
        {
            ComboArea.DataSource = cnUsuarios.CargarAreas();
            ComboArea.DataValueField = "Descripcion";
            ComboArea.DataBind();
            ComboArea.Items.Insert(0, new ListItem("Seleccionar"));
        }
        public void Rol() {

            ComboRol.DataSource = cnUsuarios.CargarRol();
            ComboRol.DataValueField = "Rol";
            ComboRol.DataBind();
            ComboRol.Items.Insert(0, new ListItem("Seleccionar"));
        }

        protected void VistaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

            y = 1;
            foreach (GridViewRow row in VistaUsuarios.Rows)
            {
                if (row.RowIndex == VistaUsuarios.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#1CD1D4"); ;
                    row.ToolTip = string.Empty;
                }
                else
                {
                    row.BackColor = Color.White;
                }
            }
            string usuario= HttpUtility.HtmlDecode(VistaUsuarios.SelectedRow.Cells[2].Text);
            SqlDataReader dr = cnUsuarios.CargarNombre(usuario);
            string nombre = "";
            string apellido = "";
            while (dr.Read() == true)
            {
                nombre = dr.GetString(0);
                apellido = dr.GetString(1);
            }

            NombreTxt.Text = nombre;
            ApellidosTxt.Text = apellido;
            UsuarioTxtx.Text = HttpUtility.HtmlDecode(VistaUsuarios.SelectedRow.Cells[2].Text);
            ContraseñaTxt.Text = HttpUtility.HtmlDecode(VistaUsuarios.SelectedRow.Cells[3].Text);
            TelefonoTxt.Text = HttpUtility.HtmlDecode(VistaUsuarios.SelectedRow.Cells[7].Text);
            CorreoTxt.Text = HttpUtility.HtmlDecode(VistaUsuarios.SelectedRow.Cells[6].Text);
            ComboArea.SelectedValue = HttpUtility.HtmlDecode(VistaUsuarios.SelectedRow.Cells[5].Text);
            ComboRol.SelectedValue = HttpUtility.HtmlDecode(VistaUsuarios.SelectedRow.Cells[8].Text);
        }

        protected void btnRegistra_Click(object sender, EventArgs e)
        {
            if (y == 1)
            {
                //modificar
                cnUsuarios.ModificarUsuario(UsuarioTxtx.Text, ContraseñaTxt.Text, NombreTxt.Text, ApellidosTxt.Text, TelefonoTxt.Text, CorreoTxt.Text, ComboArea.Text, ComboRol.Text);
                Usuario();
                y = 0;
            }
            else {
                //agregar
                cnUsuarios.RegistrarUsuario(UsuarioTxtx.Text, ContraseñaTxt.Text, NombreTxt.Text, ApellidosTxt.Text,  TelefonoTxt.Text, CorreoTxt.Text, ComboArea.Text, ComboRol.Text);
                Usuario();
                y = 0;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            //Aqui va el codigo para borrar la fila seleccionada
            string usu = HttpUtility.HtmlDecode(VistaUsuarios.SelectedRow.Cells[1].Text);
            cnUsuarios.EliminarUsuario(usu);
            Usuario();
            y = 0;
        }
        protected void VistaUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string usu = VistaUsuarios.Rows[e.RowIndex].Cells[2].Text;
            cnUsuarios.EliminarUsuario(usu);
            Usuario();
            y = 0;
        }
    }
}