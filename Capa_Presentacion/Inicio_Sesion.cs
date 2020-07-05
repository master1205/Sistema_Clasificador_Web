using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
namespace Capa_Presentacion
{
    public partial class Inicio_Sesion : Form
    {
        private CN_InicioSesion cnIn = new CN_InicioSesion();

        public Inicio_Sesion()
        {
            InitializeComponent();
        }

        private void AccederBtn_Click(object sender, EventArgs e)
        {
            if (UsuarioTxt.Text.Trim() == "")
            {
                MessageBox.Show("Asegúrese de ingresar el Usuario");
                UsuarioTxt.Focus();
            }
            else if (ClaveTxt.Text.Trim() == "")
            {
                MessageBox.Show("Asegúrese de ingresar la Contraseña");
                ClaveTxt.Focus();
            }
            else {
                
                string usuario = UsuarioTxt.Text;
                string clave = ClaveTxt.Text;
                SqlDataReader dr = cnIn.inicioSesion(usuario,clave);
                if (dr.Read())
                {
                    string rol = dr.GetString(2);
                    int area = dr.GetInt32(3);
                    Consulta_Documentos.rol = rol;
                    Consulta_Documentos.numero = area;
                    if (rol == "Administrador")
                    {
                        MessageBox.Show("Bienvenido " + rol);
                        Pantalla_Administrador pa = new Pantalla_Administrador();
                        pa.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Bienvenido " + rol);
                        Consulta_Documentos consu = new Consulta_Documentos();
                        consu.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
        }
    }
}
