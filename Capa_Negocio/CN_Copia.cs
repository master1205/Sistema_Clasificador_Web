using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
namespace Capa_Negocio
{
    public class CN_Copia
    {
        CD_Copia copia = new CD_Copia();
        public DataTable tablaCopias(string nombre)
        {
            DataTable tabla = new DataTable();
            tabla = copia.muestraCopia(nombre);
            return tabla;
        }
    }
}
