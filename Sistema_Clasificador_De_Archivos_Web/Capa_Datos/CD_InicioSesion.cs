using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Capa_Datos
{
    public class CD_InicioSesion
    {
        CD_Conexion conect = new CD_Conexion();

        public SqlDataReader leer;
        public SqlCommand comando;

        public SqlDataReader inicioSesion(string usuario,string clave)
        {
            conect.AbrirConexion();
            string instruccion = "select Usuarios.Area,Usuarios.Nombre,Usuarios.Rol,Area.Area from Usuarios inner join Area on Area.Descripcion=Usuarios.Area " +
                "where Usuario collate Latin1_General_CS_AS='" + usuario + "' and Clave='" + clave + "'";
            comando = new SqlCommand(instruccion, conect.conex);
            leer = comando.ExecuteReader();
            leer.Close();
            return comando.ExecuteReader();
        }
    }
}
