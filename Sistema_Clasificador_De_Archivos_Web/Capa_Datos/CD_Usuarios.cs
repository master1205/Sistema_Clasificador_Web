using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Usuarios
    {
        private CD_Conexion conect = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando=new SqlCommand();
        DataTable tabla=new DataTable();
        public DataTable muestraTabla() {
            comando.Connection = conect.AbrirConexion();
            comando.CommandText= "select*from Usuarios";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conect.CerrarConexion();
            return tabla;
        }

    }
}
