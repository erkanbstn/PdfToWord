using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using Xceed.Words.NET;

namespace PDF_To_WORD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                PDDocument doc = PDDocument.load(txtDosyaYolu.Text);
                PDFTextStripper stripper = new PDFTextStripper();
                txtPdfDosyasi.Text = (stripper.getText(doc));
                var docName = Path.GetFileNameWithoutExtension(txtDosyaYolu.Text) + ".docx";
                var wordDoc = DocX.Create(docName);
                wordDoc.InsertParagraph(txtPdfDosyasi.Text);
                wordDoc.Save();
                Process.Start(docName);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("PDF Dosyası Belirlenemeyen Bir Sebepten Ötürü WORD Dosyası Haline Getirilemedi..", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Opf.Filter = "PDF Dosyası |*.pdf";
            if (Opf.ShowDialog() == DialogResult.OK)
            {
                txtDosyaYolu.Text = Opf.FileName;
            }
            else
            {
                XtraMessageBox.Show("Lütfen Dönüştürmek İstediğiniz PDF Dosyasını Seçiniz..", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
