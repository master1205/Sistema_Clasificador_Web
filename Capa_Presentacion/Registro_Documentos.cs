using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
namespace Capa_Presentacion
{
    public partial class Registro_Documentos : Form
    {
        CN_RegistroDocumentos registroDoc = new CN_RegistroDocumentos();
        string descripcion = "";
        private string nombreDocumento;
        public Registro_Documentos()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ArchivoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Subir Archivo",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "pdf",
                Filter = "Pdf Files | *.pdf",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                Rutalbl.Text = openFileDialog1.FileName;
                //axAcroPDF1.src = lblRuta.Text;
            }
        }

        public void generaNombre() {
            string area = comboArea.SelectedItem.ToString();
            string clasificador = comboClasificador.SelectedItem.ToString();
            string a = "", cla = "";
            DataTable ar1 = registroDoc.area(area);
            for (int i = 0; i < ar1.Rows.Count; i++)
            {
                a = (ar1.Rows[i]["Area"].ToString());
            }
            int countStart = registroDoc.contador(a);
            DataTable ar2 = registroDoc.clasificador(area);
            for (int i = 0; i < ar2.Rows.Count; i++)
            {
                cla = (ar2.Rows[i]["Clasificador"].ToString());
            }

            DateTime hot = DateTime.Now;
            string fecha = hot.ToString("dd-MM-yyyy");
            nombreDocumento = "0" + a + "0" + cla + "0" + 1 + "_" + fecha;
            MessageBox.Show(nombreDocumento);
        }

        public void CargarArea()
        {
            DataTable ar = registroDoc.CargarArea();
            for (int i = 0; i < ar.Rows.Count; i++)
            {
                comboArea.Items.Add(ar.Rows[i]["Descripcion"]);
            }
        }
        public void CargarClasificador()
        {
            DataTable ar = registroDoc.CargarClasificadores();
            for (int i = 0; i < ar.Rows.Count; i++)
            {
                comboClasificador.Items.Add(ar.Rows[i]["Descripcion"]);
            }
        }
        public void enviarDescripcion() {
            object cb = comboClasificador.SelectedItem;
            DataTable ar = registroDoc.RecibeDescripcion(cb);
            for (int i = 0; i < ar.Rows.Count; i++)
            {
                descripcion = (ar.Rows[i]["Clasificador"].ToString());
            }
        }
        public void cargarSubCla()
        {
            string clasificador="";
            string area = comboClasificador.SelectedItem.ToString();
            DataTable ar2 = registroDoc.clasificador(area);
            for (int i = 0; i < ar2.Rows.Count; i++)
            {
                clasificador = (ar2.Rows[i]["Clasificador"].ToString());
            }
            DataTable ar = registroDoc.cargaSubClasi(clasificador);
            for (int i = 0; i < ar.Rows.Count; i++)
            {
                comboSubClasi.Items.Add(ar.Rows[i]["Descripcion"]);
            }
        }
        private void Registro_Documentos_Load(object sender, EventArgs e)
        {
            CargarArea();
            CargarClasificador();
        }

        private void comboClasificador_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSubClasi.Items.Clear();
            cargarSubCla();
        }
        protected void insertarDocumento() {

            string area = comboArea.SelectedItem.ToString();
            string clasificador = comboClasificador.SelectedItem.ToString();
            string subclasificador = comboSubClasi.SelectedItem.ToString();
            string cla = "", subcla = "";
            int ar=0;

            DataTable ar1 = registroDoc.area(area);
            for (int i = 0; i < ar1.Rows.Count; i++)
            {
                ar= Int16.Parse( ar1.Rows[i]["Area"].ToString());
                MessageBox.Show(""+ar);
            }
            DataTable ar2 = registroDoc.clasificador(clasificador);
            for (int i = 0; i < ar2.Rows.Count; i++)
            {
                cla = (ar2.Rows[i]["Clasificador"].ToString());
            }
            MessageBox.Show(cla);
            DataTable ar3 = registroDoc.subClasificador(subclasificador);
            for (int i = 0; i < ar3.Rows.Count; i++)
            {
                subcla = (ar3.Rows[i]["Id"].ToString());
            }
            MessageBox.Show(subcla);
            try
            {
                DateTime hot = DateTime.Now;
                string remitente = RemitenteTxt.Text.ToString();
                string Asunto = AsuntoTxt.Text.ToString();
                string fecha = hot.ToString("dd-MM-yyyy");
                string solicitud = DescripcionTxt.Text.ToString();
                string Clasificador = comboClasificador.SelectedItem.ToString();
                string subCla = comboSubClasi.SelectedItem.ToString();
                generaNombre();
                
                registroDoc.resgistroDocumento(remitente,Asunto,fecha,solicitud,ar,cla,subcla,nombreDocumento);
                
                MessageBox.Show("Registrado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }

        private void SubirArchivoBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(RemitenteTxt.Text) && !string.IsNullOrEmpty(AsuntoTxt.Text) && !string.IsNullOrEmpty(DescripcionTxt.Text) && comboArea.SelectedIndex >= 0 && comboClasificador.SelectedIndex >= 0)
            {
                insertarDocumento();
            }
            else {
                MessageBox.Show("Llene todos los campos");
            }
        }
    }
}
