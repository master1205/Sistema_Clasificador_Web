using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Capa_Datos
{    
   public class CD_Copia
    {
        DataTable tabla;
        CD_Conexion conect = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        public DataTable muestraCopia(string nombre)
        {
            tabla = new DataTable();
            comando.Connection = conect.AbrirConexion();
            comando.CommandText = "select Documento, Remitente, Asunto, FechaIngreso,Solicitud,NombreDoc from copiaPara where Copia='"+nombre+"';";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conect.CerrarConexion();
            return tabla;
        }
    }
}
