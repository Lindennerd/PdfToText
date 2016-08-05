using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfToText
{
    public partial class Form1 : Form
    {
        public string PdfFileName { get; set; }
        public string SelectedOutputFolder { get; set; }
        public bool AllPages { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPdfSearch_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (.pdf)|*.pdf";
            openFileDialog.ShowDialog();
            PdfFileName = new FileInfo(openFileDialog.FileName).Name;
            txtPDFPath.Text = openFileDialog.FileName;
        }

        private void btnOutputSearch_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();
            SelectedOutputFolder = folderBrowser.SelectedPath;
            txtOutputPath.Text = folderBrowser.SelectedPath;
        }

        private void rdSpecificRange_CheckedChanged(object sender, EventArgs e)
        {
            numFrom.Enabled = true;
            numTo.Enabled = true;
            AllPages = false;
        }

        private void rdAllPages_CheckedChanged(object sender, EventArgs e)
        {
            numFrom.Enabled = false;
            numTo.Enabled = false;
            AllPages = true;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                var processor = new Processor.PDFProcessor();
                var textFromPDF = processor.GetTextFromPDF(txtPDFPath.Text,
                    AllPages ? 0 : (int)numFrom.Value,
                    AllPages ? 0 : (int)numTo.Value);
                var outputFileName = string.Format("{0}/{1}",
                    SelectedOutputFolder,
                    PdfFileName.Replace("pdf", "txt"));

                CreateFile(outputFileName, textFromPDF);
                MessageBox.Show("Processamento Concluido");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateFile(string outputFileName, string text)
        {
            using (var writer = new StreamWriter(outputFileName))
            {
                writer.Write(text);
            }
        }
    }
}
