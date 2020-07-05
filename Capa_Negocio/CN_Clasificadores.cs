using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_Negocio
{
    public class CN_Clasificadores
    {
        private CD_Clasificadores cdClasificador = new CD_Clasificadores();

        public DataTable tablaUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = cdClasificador.muestraTabla();
            return tabla;
        }

        public void RegistrarClasificador(string descr)
        {
            cdClasificador.RegistrarClasificador(descr);
        }

        public void ModificarClasificador(string cla, string descr)
        {
            cdClasificador.ModificarClasificador(cla, descr);
        }

        public void EliminarClasificador(string descr)
        {
            cdClasificador.EliminarClasificador(descr);
        }

    }
}
