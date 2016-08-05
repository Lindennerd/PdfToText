using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfToText.Processor
{
    public class PDFProcessor
    {
        public string GetTextFromPDF(String pdfPath, int from, int to)
        {
            PdfReader reader = new PdfReader(pdfPath);

            StringWriter output = new StringWriter();

            int startPage = from != 0 ? from : 1;
            int lastPage = to != 0 ? to : reader.NumberOfPages;

            for (int i = startPage; i <= lastPage; i++)
            {
                output.WriteLine(PdfTextExtractor.GetTextFromPage(reader, i, new LocationTextExtractionStrategy()));
            }

            return output.ToString();
        }
    }
}
