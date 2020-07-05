using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class CN_Documentos
    {
        CD_Documentos cd_Doc = new CD_Documentos();
        public DataTable tablaDocumentos()
        {
            DataTable tabla = new DataTable();
            tabla = cd_Doc.muestraTabla();
            return tabla;
        }
        public DataTable tablaDocumentos2(int numero)
        {
            DataTable tabla = new DataTable();
            tabla = cd_Doc.muestraTabla2(numero);
            return tabla;
        }
        public DataTable tablaEstado1(string estado )
        {
            DataTable tabla = new DataTable();
            tabla = cd_Doc.busqeudaEstado(estado);
            return tabla;
        }
        public DataTable tablaEstado2(string estado, int area)
        {
            DataTable tabla = new DataTable();
            tabla = cd_Doc.busqeudaEstado2(estado, area);
            return tabla;
        }
        public DataTable consultaGeneral(int numero) {
            DataTable tabla = new DataTable();
            tabla = cd_Doc.consultaGeneral(numero);
            return tabla;
        }
    }
}
