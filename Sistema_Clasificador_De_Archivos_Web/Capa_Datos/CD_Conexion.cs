using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Conexion
    {

        public SqlDataReader leer;
        public SqlCommand comando;
        public DataTable tabla;
        public SqlConnection conex = new SqlConnection("Data Source=.; Initial Catalog=SistemaClasificadorDeArchivos;Integrated Security=true;");

        public SqlConnection AbrirConexion()
        {
            if (conex.State == ConnectionState.Closed)
                conex.Open();
            return conex;
        }
        public SqlConnection CerrarConexion()
        {
            if (conex.State == ConnectionState.Open)
                conex.Close();
            return conex;
        }

    }
}
