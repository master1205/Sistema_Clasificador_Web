using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Negocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios cdUsuario = new CD_Usuarios();

        public DataTable tablaUsuarios() {
            DataTable tabla = new DataTable();
            tabla = cdUsuario.muestraTabla();
            return tabla;
        }

    }
}
