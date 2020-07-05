using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Clasificadores
    {

        private CD_Conexion conect = new CD_Conexion();

        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable tabla;

        public DataTable muestraTabla()
        {
            tabla = new DataTable();
            comando.Connection = conect.AbrirConexion();
            comando.CommandText = "select * from Clasificador";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conect.CerrarConexion();
            return tabla;
        }

        public void RegistrarClasificador(string descr)
        {
            SqlCommand commandRowCount = new SqlCommand("select count('Clasificador') from Clasificador", conect.AbrirConexion());
            int countStart = System.Convert.ToInt32(commandRowCount.ExecuteScalar());
            string clasif = (countStart + 1) + "UP";

            string instruccion = "insert into Clasificador values('" + clasif + "', '" + descr + "');";
            Utilidades.Ejecutar(instruccion);
        }

        public void ModificarClasificador(string clas, string descr)
        {
            string instruccion = "update Clasificador set Descripcion='" + descr + "' where Clasificador='" + clas + "';";
            Utilidades.Ejecutar(instruccion);
        }

        public void EliminarClasificador(string descr)
        {
            string instruccion = "delete from Clasificador where Descripcion='" + descr + "';";
            Utilidades.Ejecutar(instruccion);
        }
    }
}
