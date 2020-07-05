using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidades;
namespace Capa_Presentacion
{
    public partial class Consulta_Documentos : Form
    {
        CN_Documentos cnDoc = new CN_Documentos();
        CE_Archivos_Google archivos = new CE_Archivos_Google();
        public static int numero;
        public static string rol;
       // private static string[] Scopes = { DriveService.Scope.Drive };
        private static string aplicacionNombre = "GoogleDriveAPIStart";
        private static string _downloadFilePath = @"C:\Users\MarioBrosPlus\Downloads";
        public Consulta_Documentos()
        {
            InitializeComponent();
        }

        public void tablaDocumentos()
        {
            DocumentosView.DataSource = cnDoc.tablaDocumentos();
        }
        public void tablaDocumentos2() {
            DocumentosView.DataSource = cnDoc.tablaDocumentos2(numero);
        }
        public void muestraTabla() {
             if (rol.Equals("Administrador"))
            {
                tablaDocumentos();
            }
            else {
                tablaDocumentos2(); 
            }
        }
        private void Consulta_Documentos_Load(object sender, EventArgs e)
        {
           
        }
        public void mostarest(string estado)
        {
            if (!rol.Equals("Administrador"))
            {
                DocumentosView.DataSource = cnDoc.tablaEstado2(estado,numero);
            }
            else
            {
                DocumentosView.DataSource = cnDoc.tablaEstado1(estado);
            }
        }

        private void ProgresoBtn_Click(object sender, EventArgs e)
        {
            mostarest("1");
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            mostarest("2");
        }

        private void RechazarBtn_Click(object sender, EventArgs e)
        {
            mostarest("3");
        }

        private void TodosBtn_Click(object sender, EventArgs e)
        {
            if (!rol.Equals("Administrador"))
            {
                DocumentosView.DataSource = cnDoc.consultaGeneral(numero);
            }
            else
            {
                DocumentosView.DataSource = cnDoc.ConsultaGeneral2();
            }
        }

        private void AceptarBtn_Click_1(object sender, EventArgs e)
        {
            try
            {

                string nombre = "";
                foreach (DataGridViewRow row in DocumentosView.SelectedRows)
                {
                    nombre = row.Cells["NombreDoc"].Value.ToString();
                }
                MessageBox.Show("nombre= " + nombre);
                cnDoc.aceptarDocumento(nombre);
                muestraTabla();
            }
            catch (Exception ss)
            {
                MessageBox.Show(ss.ToString());
            }
        }

        private void DescargarBtn_Click(object sender, EventArgs e)
        {
            string nombre = "";
            foreach (DataGridViewRow row in DocumentosView.SelectedRows)
            {
                nombre = row.Cells["NombreDoc"].Value.ToString();
            }
            SqlDataReader dr = cnDoc.descargarDocumento(nombre);
            string codigo = "";
            while (dr.Read()==true)
            {
                codigo = dr.GetString(0);
            }
            archivos.descargarArc(nombre,codigo);
        }

        private void RechazarDocumentoBtn_Click(object sender, EventArgs e)
        {
            string nombre = "";
            foreach (DataGridViewRow row in DocumentosView.SelectedRows)
            {
                nombre = row.Cells["NombreDoc"].Value.ToString();
            }
            cnDoc.rechazarDocumento(nombre);
            SqlDataReader dr = cnDoc.rechazarDocumentoVista(nombre);
            string codigo = "";
            while (dr.Read()==true)
            {
                codigo = dr.GetString(0);
            }
            archivos.recharArchivo(nombre);
            MessageBox.Show("Operaci+on Exitosa");
        }
    }
}
