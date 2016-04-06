using System;
using System.Linq;
using iTextSharp.text.pdf;

namespace Pdf2Pdfa
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() != 3)
            {
                Console.WriteLine("Usage: Pdf2Pdfa.exe <InputPath> <OutputPath> <PdfAConformanceLevel>\n" +
                                  "Example: Pdf2Pdfa.exe file.pdf file_pdfa.pdf PDF_A_3B");
                return;
            }

            try
            {
                PdfAConformanceLevel pdfAConformanceLevel = (PdfAConformanceLevel)Enum.Parse(typeof(PdfAConformanceLevel), args[2]);

                Pdf2PdfaLib.Converter.Convert(args[0], args[1], pdfAConformanceLevel);

                Console.WriteLine("Converted to " + args[1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
