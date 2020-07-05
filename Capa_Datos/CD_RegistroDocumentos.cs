using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{

    public class CD_RegistroDocumentos
    {
        CD_Conexion cn = new CD_Conexion();
        //COMBOS
        public DataSet CargarArea()
        {
            string instruccion = "Select Descripcion from Area order by Descripcion;";
            return Utilidades.Ejecutar(instruccion);
        }
        public DataSet CargarClasificador()
        {
            string instruccion = "Select Descripcion from Clasificador order by Descripcion;";
            return Utilidades.Ejecutar(instruccion);
        }

        public DataSet recibeDescripcion(object descripcion)
        {
            string instruccion = "Select Clasificador from Clasificador where Descripcion='" + descripcion + "'";
            return Utilidades.Ejecutar(instruccion);
        }
        public DataSet CargarSubclasificador(string clasificador)
        {
            string instruccion = "Select * from SubClasificador where Id like '" + clasificador + "%'";
            return Utilidades.Ejecutar(instruccion);
        }
        //Insertar Documento Base de Datos
        public DataSet Area(string descripcion)
        {
            string instruccion = "";
            instruccion = "Select Area from Area where Descripcion='" + descripcion + "'";
            return Utilidades.Ejecutar(instruccion);
        }
        public DataSet CopiaPara()
        {
            string instruccion = "";
            instruccion = "select Nombre from Usuarios where Rol='Administrativo'";
            return Utilidades.Ejecutar(instruccion);
        }
        public DataSet Clasificador(string clasificador)
        {
            string instruccion = "Select Clasificador from Clasificador where Descripcion='" + clasificador + "'";
            return Utilidades.Ejecutar(instruccion);
        }
        public DataSet subClasificador(string subClasificador)
        {
            string instruccion = "Select Id from SubClasificador where Descripcion like'" + subClasificador + "%'";
            return Utilidades.Ejecutar(instruccion);
        }
        public void registrarCopia(string remitente, string asunto, string fecha, string solicitud, string nombreAdmi, string nombreDocumento,string id)
        {
            try
            {
                string instruccion = "insert into copiaPara values('" + remitente + "','" + asunto + "','" + fecha + "','" + solicitud + "','" + nombreAdmi + "','" + nombreDocumento + "','" + id + "')";
                Utilidades.Ejecutar(instruccion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void registrarDocumento(string remitente, string asunto, string fecha, string solicitud, int area, string clasificador, string subclasificador, string nombreDocumento,string id)
        {
            try
            {
                string instruccion = "insert into Documento values('" + remitente + "','" + asunto + "','" + fecha + "','" + solicitud + "'," + area + ",'" + clasificador + "','"
                     + subclasificador + "','" + 1 + "','" + nombreDocumento + "','" + id + "')";
                Utilidades.Ejecutar(instruccion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int contador(string are)
        {
            try
            {
                SqlCommand commandRowCount = new SqlCommand("select count('Area') from Documento where Area=" + are + "", cn.AbrirConexion());

                int countStart = System.Convert.ToInt32(commandRowCount.ExecuteScalar());
                return countStart;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
