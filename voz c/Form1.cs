using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Speech.Recognition;
// no esta termindo le falta algo que no conosco
namespace voz_c
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine escucha = new SpeechRecognitionEngine();
        private object progressBar1;
        private object txtHablar;

        public object PdfWriter { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                escucha.SetInputToDefaultAudioDevice();
                escucha.LoadGrammar(new DictationGrammar());
                escucha.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(ReconocedorDeVoz);
                escucha.RecognizeAsync(RecognizeMode.Multiple);
                escucha.AudioLevelUpdated += NivelAudio;

            }
            catch (InvalidOperationException)
            {

                MessageBox.Show("No hay acceso al microfono.. o no esta conectado");
            }
        }
        public void ReconocedorDeVoz(object sender, SpeechRecognizedEventArgs e)
        {
            foreach (RecognizedWordUnit palabra in e.Result.Words)
            {
                txtHablar.Text += palabra.Text + " ";
             }
        }
        public void NivelAudio(object sender, AudioLevelUpdatedEventArgs e)
        {
            int audio = e.AudioLevel;
            progressBar1.Value = audio;
        }


        private void btnLimpiar_Click(object sender, EventArgs e) => txtHablar.Tt = "";

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPdf_Click(object sender, EventArgs e)
        {
            // string nombre="Prueba";
            GenerarPDF(@"C:\Users\DIANYS\Desktop\pdf\PruebaUno.pdf");
        }

        private void GenerarPDF(string archivo)
        {
            Document documento = new Document();

            //Nota aqui debes controlar la exepcion para que no genere un error...
            try
            {
                PdfWriter.GetInstance(
                    documento, new FileStream(archivo, FileMode.Create));
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro la ruta de la carpeta:  /Desktop/pdf/PruebaUno.pdf", "Error");
            }
            try
            {
                Paragraph p = new Paragraph(txtHablar.Text);
                documento.Open();
                documento.Add(p);
                documento.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);

                //string nombreArchivo;
                //string partes;
                //nombreArchivo = txtHablar.Text;

                //partes = nombreArchivo.Split(new string[] {' '});
                //string caracterespacio = partes[0];



            }








        }
    }           
}
