using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Capa_Negocio;
using File = Google.Apis.Drive.v3.Data.File;
using System.Data;

namespace Sistema_Clasificador_De_Archivos_Web
{
    public partial class RegistrarDocumentos : System.Web.UI.Page
    {
        private static string[] Scopes = { DriveService.Scope.Drive };
        private static string FolderId = "1_YQnAhBttwxdseqxwroFl5PeoWdlsfBK";
        private static string aplicacionNombre = "GoogleAPIStart";
        private static string _FilePath;
        private static string Id2;
        private static string _ContentType = "application/x-pdf";
        private string nombreDocumento = "";
        CN_RegistroDocumentos registroDoc = new CN_RegistroDocumentos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Area();
                Clasificador();
                copiaPara();
            }
        }

        //Carga del Archivo a la nube
        private static UserCredential GetUserCredential()
        {
            using (var Stream = new FileStream(@"C:\Users\MarioBrosPlus\Downloads\Sistema_Clasificador_De_Archivos_Web\Sistema_Clasificador_De_Archivos_Web\Sistema_Clasificador_De_Archivos_Web\bin\client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string createPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                createPath = Path.Combine(createPath, "driveApiCredentials", "drive-credentials.json");
                return GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(Stream).Secrets, Scopes,
                    "User", System.Threading.CancellationToken.None, new FileDataStore(createPath, true)).Result;
            }
        }
        private static DriveService GetDriveService(UserCredential credential)
        {
            return new DriveService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = aplicacionNombre
            });
        }

        private static string UploadFileToDrive(DriveService service, string FileName, string filePath, string contentType)
        {
            var fileMetaData = new File();
            fileMetaData.Name = FileName;
            fileMetaData.Parents = new List<string> { FolderId };
            FilesResource.CreateMediaUpload request;
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                request = service.Files.Create(fileMetaData, stream, contentType);
                request.Upload();
            }
            var file = request.ResponseBody;
            Id2 = file.Id;
            return file.Id;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (this.file.HasFile)
            {                
                this.file.SaveAs(@"C:\Users\MarioBrosPlus\Documents\Pdf\" + this.file.FileName + "");
                _FilePath = @"C:\Users\MarioBrosPlus\Documents\Pdf\" + this.file.FileName + "";
                UserCredential credential = GetUserCredential();
                DriveService service = GetDriveService(credential);
                generaNombre();
                UploadFileToDrive(service, nombreDocumento, _FilePath, _ContentType);
                System.IO.File.Delete(@"C:\Users\MarioBrosPlus\Documents\Pdf\" + this.file.FileName + "");
                insertarDocumento();
            }
        }
        public void generaNombre()
        {
            string area = ComboArea.SelectedItem.ToString();
            string clasificador = ComboClasificador.SelectedItem.ToString();
            string a = "", cla = "";
            DataTable ar1 = registroDoc.area(area);
            for (int i = 0; i < ar1.Rows.Count; i++)
            {
                a = (ar1.Rows[i]["Area"].ToString());
            }
            int countStart = registroDoc.contador(a);
            DataTable ar2 = registroDoc.clasificador(clasificador);
            for (int i = 0; i < ar2.Rows.Count; i++)
            {
                cla = (ar2.Rows[i]["Clasificador"].ToString());
            }

            DateTime hot = DateTime.Now;
            string fecha = hot.ToString("dd-MM-yyyy");
            nombreDocumento = "0" + a + "0" + cla + "0" + countStart + "_" + fecha;
        }
        protected void insertarDocumento()
        {

            string area = ComboArea.SelectedItem.ToString();
            string clasificador = ComboClasificador.SelectedItem.ToString();
            string subclasificador = ComboSubClasificador.SelectedItem.ToString();
            string copia = ComboCopia.SelectedItem.ToString();
            string cla = "", subcla = "";
            int ar = 0;

            DataTable ar1 = registroDoc.area(ComboArea.SelectedItem.ToString());
            for (int i = 0; i < ar1.Rows.Count; i++)
            {
                ar = Int16.Parse(ar1.Rows[i]["Area"].ToString());
            }
            DataTable ar2 = registroDoc.clasificador(ComboClasificador.SelectedItem.ToString());
            for (int i = 0; i < ar2.Rows.Count; i++)
            {
                cla = (ar2.Rows[i]["Clasificador"].ToString());
            }
            DataTable ar3 = registroDoc.subClasificador(ComboSubClasificador.SelectedItem.ToString());
            for (int i = 0; i < ar3.Rows.Count; i++)
            {
                subcla = (ar3.Rows[i]["Id"].ToString());
            }
            try
            {
                DateTime hot = DateTime.Now;
                string remitente = RemitenteTxt.Text.ToString();
                string Asunto = AsuntoTxt.Text.ToString();
                string fecha = hot.ToString("dd-MM-yyyy");
                string solicitud = DescripcionTxt.Text.ToString();
                if (ComboCopia.Text.Equals("Selecciona"))
                {
                    registroDoc.resgistroDocumento(remitente, Asunto, fecha, solicitud, ar, cla, subcla, nombreDocumento,Id2);
                }
                else
                {
                    registroDoc.resgistroDocumento(remitente, Asunto, fecha, solicitud, ar, cla, subcla, nombreDocumento,Id2);
                    registroDoc.registrarCopia(remitente, Asunto, fecha, solicitud, copia, nombreDocumento,Id2);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Area()
        {
            //Codigo para el area se llena el comboArea

            ComboArea.DataSource = registroDoc.CargarArea();
            ComboArea.DataValueField = "Descripcion";
            ComboArea.DataBind();
            ComboArea.Items.Insert(0, "Selecciona");
        }
        public void Clasificador()
        {
            //Codigo para el Clasificador se llena el comboClasificador
            ComboClasificador.DataSource = registroDoc.CargarClasificadores();
            ComboClasificador.DataValueField = "Descripcion";
            ComboClasificador.DataBind();
            ComboClasificador.Items.Insert(0, "Selecciona");
        }

        public void copiaPara()
        {
            //Solo va el nombre de los usuarios que tiene ese Rol
            ComboCopia.DataSource = registroDoc.CargarCopiaPara();
            ComboCopia.DataValueField = "Nombre";
            ComboCopia.DataBind();
            ComboCopia.Items.Insert(0, "Selecciona");
        }
        protected void ComboClasificador_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                //Cargar datos
                string clasificador = "";
                DataTable ar2 = registroDoc.clasificador(ComboClasificador.SelectedValue);
                for (int i = 0; i < ar2.Rows.Count; i++)
                {
                    clasificador = (ar2.Rows[i]["Clasificador"].ToString());
                }
                ComboSubClasificador.DataSource = registroDoc.cargaSubClasi(clasificador);
                ComboSubClasificador.DataValueField = "Descripcion";
                ComboSubClasificador.DataBind();
                ComboSubClasificador.Items.Insert(0, "Selecciona");

        }
    }
}