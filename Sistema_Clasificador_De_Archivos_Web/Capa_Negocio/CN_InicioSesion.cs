using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data.SqlClient;
namespace Capa_Negocio
{
    public class CN_InicioSesion
    {
        CD_InicioSesion cdInicio = new CD_InicioSesion();
        public SqlDataReader inicioSesion(string Usuario, string Clave) {
             SqlDataReader def=cdInicio.inicioSesion(Usuario,Clave);
            return def;
        }
    }
}
