using Servicios.Interfaces;

namespace Servicios.Impl;

public class PdfReportGeneratorGeneratorImpl : IPdfReportGenerator
{
    public async Task Generate(IReport report, object data, string reportName)
    {
        await report.Export(reportName, data);
    }
}