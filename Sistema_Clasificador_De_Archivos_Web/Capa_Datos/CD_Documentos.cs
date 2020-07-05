using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Documentos
    {
        CD_Conexion conect = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable tabla = new DataTable();
        public DataTable muestraTabla()
        {
            comando.Connection = conect.AbrirConexion();
            comando.CommandText = "select Documento.NombreDoc,Documento.Remitente,Documento.Asunto,Documento.FechaIngreso,Documento.Solicitud,Area.Descripcion,Estado.DEscripcion as Estado from Documento inner join Area on Area.Area=Documento.Area inner join Estado on Documento.Estado=Estado.Estado";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            return tabla;
        }
        public DataTable muestraTabla2(int numero) {
            comando.Connection = conect.AbrirConexion();
            comando.CommandText = "select Documento.NombreDoc,Documento.Remitente,Documento.Asunto,Documento.FechaIngreso,Documento.Solicitud,Area.Descripcion,Estado.DEscripcion as Estado from Documento inner join Area on Area.Area=Documento.Area inner join Estado on Documento.Estado=Estado.Estado";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            return tabla;
        }
        public DataTable busqeudaEstado(string Estado) {
            comando.Connection = conect.AbrirConexion();
            comando.CommandText = "select Documento.NombreDoc,Documento.Remitente,Documento.Asunto,Documento.FechaIngreso,Documento.Solicitud,Area.Descripcion,Estado.DEscripcion as Estado from Documento inner join Area on Area.Area = Documento.Area inner join Estado on Documento.Estado = Estado.Estado where Documento.Estado = '" + Estado + "'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            return tabla;
        }
        public DataTable busqeudaEstado2(string Estado, int numero)
        {
            comando.Connection = conect.AbrirConexion();
            comando.CommandText = "select Documento.NombreDoc,Documento.Remitente,Documento.Asunto,Documento.FechaIngreso,Documento.Solicitud,Estado.DEscripcion as Estado from Documento inner join Area on Area.Area=Documento.Area inner join Estado on Documento.Estado=Estado.Estado where Documento.Estado='" + Estado + "' and Documento.Area='" + numero + "'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            return tabla;
        }
        public DataTable consultaGeneral(int numero)
        {
            comando.Connection = conect.AbrirConexion();
            comando.CommandText = "select Documento.NombreDoc,Documento.Remitente,Documento.Asunto,Documento.Solicitud,Documento.FechaIngreso,"
            + "Estado.DEscripcion as Estado from Documento inner join Area on Area.Area = Documento.Area inner join Estado on Documento.Estado = Estado.Estado " +
            "where(Documento.Estado = 1 or Documento.Estado = 2) and Documento.Area ='" + numero + "'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            return tabla;
        }
    }
}
