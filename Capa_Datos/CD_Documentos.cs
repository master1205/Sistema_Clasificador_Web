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
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        public DataTable muestraTabla()
        {
            comando.Connection = conect.AbrirConexion();
            comando.CommandText = "select Documento.NombreDoc,Documento.Remitente,Documento.Asunto,Documento.FechaIngreso,Documento.Solicitud,Area.Descripcion,Estado.DEscripcion as Estado from Documento inner join Area on Area.Area=Documento.Area inner join Estado on Documento.Estado=Estado.Estado";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            leer.Close();
            return tabla;
        }
        public DataTable muestraTabla2(int numero) {
            tabla = new DataTable();
            comando.Connection = conect.AbrirConexion();
            comando.CommandText = "select Documento.NombreDoc,Documento.Remitente,Documento.Asunto,Documento.FechaIngreso,Documento.Solicitud,Area.Descripcion,Estado.Descripcion as Estado from Documento inner join Area on Area.Area=Documento.Area inner join Estado on Documento.Estado=Estado.Estado where (Documento.Estado = 1 or Documento.Estado = 2) and Area.Area='" + numero+"'";
            leer =comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            leer.Close();
            return tabla;
        }
        public DataTable busqeudaEstado(string Estado) {
            comando.Connection = conect.AbrirConexion();
            comando.CommandText = "select Documento.NombreDoc,Documento.Remitente,Documento.Asunto,Documento.FechaIngreso,Documento.Solicitud,Area.Descripcion,Estado.DEscripcion as Estado from Documento inner join Area on Area.Area = Documento.Area inner join Estado on Documento.Estado = Estado.Estado where Documento.Estado = '" + Estado + "'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            leer.Close();
            return tabla;
        }
        public DataTable busqeudaEstado2(string Estado, int numero)
        {
            tabla = new DataTable();
            comando.Connection = conect.AbrirConexion();
            comando.CommandText = "select Documento.NombreDoc,Documento.Remitente,Documento.Asunto,Documento.FechaIngreso,Documento.Solicitud,Estado.DEscripcion as Estado from Documento inner join Area on Area.Area=Documento.Area inner join Estado on Documento.Estado=Estado.Estado where Documento.Estado='" + Estado + "' and Documento.Area='" + numero + "'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            comando.Parameters.Clear();
            return tabla;
        }
        public DataTable consultaGeneral(int numero)
        {
            tabla = new DataTable();
            comando.Connection = conect.AbrirConexion();
            comando.CommandText = "select Documento.NombreDoc,Documento.Remitente,Documento.Asunto,Documento.Solicitud,Documento.FechaIngreso,"
            + "Estado.DEscripcion as Estado from Documento inner join Area on Area.Area = Documento.Area inner join Estado on Documento.Estado = Estado.Estado " +
            "where (Documento.Estado = 1 or Documento.Estado = 2) and Documento.Area ='" + numero + "'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            comando.Parameters.Clear();
            return tabla;
        }
        //desde aqui empieza tambien a copiar
        public DataTable consultaGeneral2()
        {
            tabla = new DataTable();
            comando.Connection = conect.AbrirConexion();
            comando.CommandText = "select Documento.NombreDoc,Documento.Remitente,Documento.Asunto,Documento.FechaIngreso,Documento.Solicitud,Area.Descripcion,Estado.DEscripcion as Estado from Documento inner join Area on Area.Area=Documento.Area inner join Estado on Documento.Estado=Estado.Estado";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            comando.Parameters.Clear();
            return tabla;
        }
        public void aceptarDocumento(string nombre) {
            comando.Connection = conect.AbrirConexion();
            //comando = new SqlCommand("update Documento set Estado='2' where NombreDoc='" + nombre + "'",conect.conex);
            //comando.ExecuteNonQuery();
            Utilidades.Ejecutar("update Documento set Estado='2' where NombreDoc='" + nombre + "'");
        }
        public SqlDataReader descargaDocumento(string nombre) {
            comando.Connection = conect.AbrirConexion();
            comando = new SqlCommand("select Id_Documento from Documento where NombreDoc='" + nombre + "'", conect.conex);
            leer = comando.ExecuteReader();
            leer.Close();
            return comando.ExecuteReader();
        }
        public void rechazarDocumento(string nombre) {
            comando.Connection = conect.AbrirConexion();
            //comando = new SqlCommand("update Documento set Estado='3' where NombreDoc='" + nombre + "'", conect.conex);
            Utilidades.Ejecutar("update Documento set Estado='3' where NombreDoc='" + nombre + "'");

            
        }
        public SqlDataReader rechazarDocumentoVista(string nombre)
        {
            comando.Connection = conect.AbrirConexion();
            comando = new SqlCommand("select Id_Documento from Documento where NombreDoc='" + nombre + "'", conect.conex);
            leer = comando.ExecuteReader();
            leer.Close();
            return comando.ExecuteReader();
        }
    }
}
