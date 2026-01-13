namespace Servicios.Interfaces;

public interface IPdfReportGenerator
{
    Task Generate(IReport report, object data, string reportName);
}