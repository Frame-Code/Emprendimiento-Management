using Servicios.Interfaces;

namespace Servicios.Impl;
public class PdfReportGeneratorImpl : IPdfReportGenerator
{
    public Task Generate(IReport report, object data, string reportName)
    {
        // Agrega 'data' como segundo argumento aquí para corregir el error CS7036
        report.Export(reportName, data);

        return Task.CompletedTask;
    }
}