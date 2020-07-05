using Capa_Datos;
using System.Data;

namespace Capa_Negocio
{
    public class CN_SubClasificadores
    {
        private CD_Subclasificadores cdSubClasificador = new CD_Subclasificadores();
        
        public DataTable tablaSubC()
        {
            DataTable tabla = new DataTable();
            tabla = cdSubClasificador.muestraTabla();
            return tabla;
        }
        public DataTable obtenerIDClasificador(string clasificador)
        {
            DataTable tab = cdSubClasificador.IdClasificador(clasificador).Tables[0];
            return tab;
        }
        public void RegistrarSubClasificador(string clas, string descr)
        {
            cdSubClasificador.RegistrarSubClasificador(clas, descr);
        }

        public void ModificarSubClasificador(string cla, string descr)
        {
            cdSubClasificador.ModificarSubClasificador(cla, descr);
        }

        public void EliminarSubClasificador(string descr)
        {
            cdSubClasificador.EliminarSubClasificador(descr);
        }

        public DataTable CargarClasificadores()
        {
            DataTable dt = cdSubClasificador.CargarClasificador().Tables[0];
            return dt;
        }
    }
}
