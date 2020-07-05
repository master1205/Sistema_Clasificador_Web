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
        DataTable tabla;
        string area ="";
        public DataTable muestraTabla()
        {
            tabla = new DataTable();
            comando.Connection = conect.AbrirConexion();
            comando = new SqlCommand("Select* from Area",conect.conex);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            return tabla;
        }
        public void insertarArea(string descripcion) {

            comando.Connection = conect.AbrirConexion();
            comando.CommandText = "ActualizarArea";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@are", area);
            comando.Parameters.AddWithValue("@desc", descripcion);
            comando.ExecuteNonQuery();
        }
        public void ModificarArea(string area, string descr)
        {
            string instruccion = "update Area set Descripcion='" + descr + "' where Area='" + area + "';";
            Utilidades.Ejecutar(instruccion);
        }
    }
}
