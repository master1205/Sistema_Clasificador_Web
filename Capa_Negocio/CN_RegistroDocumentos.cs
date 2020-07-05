using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
namespace Capa_Negocio
{
    public class CN_RegistroDocumentos
    {

        CD_RegistroDocumentos cdRegistro = new CD_RegistroDocumentos();
        public DataTable CargarArea()
        {
            DataTable dt = cdRegistro.CargarArea().Tables[0];
            return dt;
        }
        public DataTable CargarClasificadores()
        {
            DataTable dt = cdRegistro.CargarClasificador().Tables[0];
            return dt;
        }

        public DataTable CargarCopiaPara()
        {
            DataTable dt = cdRegistro.CopiaPara().Tables[0];
            return dt;
        }
        public DataTable RecibeDescripcion(object descripcion) {
            DataTable dt = cdRegistro.recibeDescripcion(descripcion).Tables[0];
            return dt;
        }

        public DataTable cargaSubClasi(string  clasificador)
        {
            DataTable dt = cdRegistro.CargarSubclasificador(clasificador).Tables[0];
            return dt;
        }
        //Insertar Documento Base de Datos
        public DataTable area(string area) {
            DataTable dt = cdRegistro.Area(area).Tables[0];
            return dt;
        }
        public DataTable clasificador(string clasificador) {
            DataTable dt = cdRegistro.Clasificador(clasificador).Tables[0];
            return dt;
        }
        public DataTable subClasificador(string subClasificador) {
            DataTable dt = cdRegistro.subClasificador(subClasificador).Tables[0];
            return dt;
        }
        public void resgistroDocumento(string remitente, string asunto, string fecha, string solicitud, int area, string clasificador, string subclasificador, string nombreDocumento, string id) {
            cdRegistro.registrarDocumento(remitente,asunto,fecha,solicitud,area,clasificador,subclasificador,nombreDocumento,id);
        }
        public int contador(string area) {
            int count = cdRegistro.contador(area);
            return count;
        }
        public void registrarCopia(string remitente, string asunto, string fecha, string solicitud, string nombreAdmi, string nombreDocumento, string id)
        {
            cdRegistro.registrarCopia(remitente, asunto, fecha, solicitud, nombreAdmi, nombreDocumento, id);
        }
    }
}
