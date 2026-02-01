using Servicios.Interfaces;

namespace Servicios.Impl;
/// <summary>
/// Implementación mínima que delega la exportación del PDF al reporte concreto.
/// </summary>
public class PdfReportGeneratorImpl : IPdfReportGenerator
{
    /// <summary>
    /// Ejecuta la exportación del reporte con los datos y nombre proporcionados.
    /// </summary>
    public Task Generate(IReport report, object data, string reportName)
    {
        // Agrega 'data' como segundo argumento aquí para corregir el error CS7036
        report.Export(reportName, data);

        return Task.CompletedTask;
    }
}
