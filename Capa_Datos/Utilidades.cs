using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    class Utilidades
    {

        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=SistemaClasificadorDeArchivos; Integrated Security=true;");
            con.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con);
            DP.Fill(DS);
            con.Close();
            return DS;
        }
    }
}
