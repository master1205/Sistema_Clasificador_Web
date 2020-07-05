using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class CD_Subclasificadores
    {
        private CD_Conexion conect = new CD_Conexion();

        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable tabla;

        public DataTable muestraTabla()
        {
            tabla = new DataTable();
            comando.Connection = conect.AbrirConexion();
            comando.CommandText = "select * from SubClasificador";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conect.CerrarConexion();
            return tabla;
        }
        public void RegistrarSubClasificador(string clasi, string descr)
        {
            SqlCommand commandRowCount = new SqlCommand("select count('Id') from SubClasificador where Id like '%" + clasi + "%'", conect.AbrirConexion());
            int countStart = System.Convert.ToInt32(commandRowCount.ExecuteScalar());
            string subclas = clasi + "-" + (countStart + 1);
            string instruccion = "insert into SubClasificador values('" + subclas + "', '" + descr + "');";
            Utilidades.Ejecutar(instruccion);
        }
        public DataSet IdClasificador(string clasificador)
        {
            string instruccion = "Select Clasificador from Clasificador where Descripcion='" + clasificador + "'";
            return Utilidades.Ejecutar(instruccion);
        }
        public void ModificarSubClasificador(string sub, string descr)
        {
            string instruccion = "update SubClasificador set Descripcion='" + descr + "' where Id='" + sub + "';";
            Utilidades.Ejecutar(instruccion);
        }

        public void EliminarSubClasificador(string descr)
        {
            string instruccion = "delete from SubClasificador where Descripcion='" + descr + "';";
            Utilidades.Ejecutar(instruccion);
        }

        public DataSet CargarClasificador()
        {
            string instruccion = "Select Descripcion from Clasificador order by Descripcion;";
            return Utilidades.Ejecutar(instruccion);
        }
    }
}
