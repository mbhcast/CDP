using CDP_Dev.PdfProvider.DataModel;

namespace AspNetCorePdf.PdfProvider
{
    public interface IMigraDocService
    {
        string CreateMigraDocPdf(PdfData pdfData);
    }
}
