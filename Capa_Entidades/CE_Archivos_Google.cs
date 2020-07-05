using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Google.Apis.Drive.v3;
using System.IO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using File = Google.Apis.Drive.v3.Data.File;
using Google.Apis.Download;
using System.Net;
using System.Diagnostics;

namespace Capa_Entidades
{
    public class CE_Archivos_Google
    {
        private static string[] Scopes = { DriveService.Scope.Drive };
        private static string aplicacionNombre = "GoogleDriveAPIStart";
        private static string _downloadFilePath = @"C:\Users\MarioBrosPlus\Downloads";

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
        private static void DownloadFileFromDrive(DriveService service, string fileid, string filePath)
        {
            var request = service.Files.Get(fileid);

            using (var memoryStream = new MemoryStream())
            {
                request.MediaDownloader.ProgressChanged += (IDownloadProgress progress) =>
                {
                    switch (progress.Status)
                    {
                        case DownloadStatus.Completed:
                            //MessageBox.Show("Descarga Completa: " + progress.BytesDownloaded);
                            break;
                        case DownloadStatus.Failed:
                            //MessageBox.Show("Descarga Fallida");
                            break;
                    }
                };
                request.Download(memoryStream);

                using (var filestream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    filestream.Write(memoryStream.GetBuffer(), 0, memoryStream.GetBuffer().Length);
                }
            }
        }
        public void descargarArc(string nombre,string codigo) {
            UserCredential credential = GetUserCredential();
            DriveService service = GetDriveService(credential);
            _downloadFilePath = @"C:\Users\MarioBrosPlus\Documents\GoogleDrive\" + nombre + ".pdf";
            DownloadFileFromDrive(service, codigo, _downloadFilePath);
            Process.Start(_downloadFilePath);

        }
    }
}
