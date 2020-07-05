using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Areas
    {
        private CD_Conexion conect = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable tabla = new DataTable();
        public DataTable muestraTabla()
        {
            comando.Connection = conect.AbrirConexion();
            comando.CommandText = "select*from Area";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            return tabla;
        }
        public SqlDataReader comboAreas()
        {

            string instruccion = "select Descripcion from Area";
            comando = new SqlCommand(instruccion, conect.conex);
            leer = comando.ExecuteReader();
            leer.Close();
            comando.Parameters.Clear();
            conect.CerrarConexion();
            return comando.ExecuteReader();
        }
    }
}
