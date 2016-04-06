# Pdf2Pdfa

Simple PDF 2 PDFa converter. Support PDF/A-2B, PDF/A-3B conformance level.

Usage: 
Pdf2Pdfa.exe \<InputPath\> \<OutputPath\> \<PdfAConformanceLevel\> or Pdf2PdfaLib.Convert(InputPath, OutputPath, PdfAConformanceLevel)

Example: 
Pdf2Pdfa.exe file.pdf file_pdfa.pdf PDF_A_3B

Using ITextSharp library with AGPL license.

Known issue: "Arial", "Arial,Bold" font
