using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Negocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios cdUsuario = new CD_Usuarios();

        public DataTable tablaUsuarios() {
            DataTable tabla = new DataTable();
            tabla = cdUsuario.muestraTabla();
            return tabla;
        }

        public void RegistrarUsuario(string nom, string ape, string usu, string cla, string tel, string corr, string are, string rol)
        {
            cdUsuario.RegistrarUsuario(nom, ape, usu, cla, tel, corr, are, rol);
        }

        public void ModificarUsuario(string orig, string nom, string ape, string cla, string tel, string corr, string are, string rol)
        {
            cdUsuario.ModificarUsuario(orig, nom, ape, cla, tel, corr, are, rol);
        }

        public void EliminarUsuario(string usu)
        {
            cdUsuario.EliminarUsuario(usu);
        }
        public SqlDataReader CargarNombre(string usuario)
        {
            SqlDataReader dt = cdUsuario.CargarNombreApellido(usuario);
            return dt;
        }
        public DataTable CargarAreas()
        {
            DataTable dt = cdUsuario.CargarArea().Tables[0];
            return dt;
        }

        public DataTable CargarRol()
        {
            DataTable dt = cdUsuario.CargarRol().Tables[0];
            return dt;
        }
    }
}
