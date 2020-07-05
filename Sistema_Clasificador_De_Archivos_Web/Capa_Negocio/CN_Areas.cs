using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Negocio
{
    public class CN_Areas
    {
        CD_Areas cdAreas = new CD_Areas();

        public DataTable tablaAreas()
        {
            DataTable tabla = new DataTable();
            tabla = cdAreas.muestraTabla();
            return tabla;
        }
        public SqlDataReader comboAreas() {
            SqlDataReader def = cdAreas.comboAreas();
            return def;
        }
    }
}
