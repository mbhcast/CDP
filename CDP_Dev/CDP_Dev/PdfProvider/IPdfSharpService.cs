using CDP_Dev.PdfProvider.DataModel;

namespace CDP_Dev.PdfProvider
{
    public interface IPdfSharpService
    {
        string CreatePdf(PdfData pdfData);
    }
}
