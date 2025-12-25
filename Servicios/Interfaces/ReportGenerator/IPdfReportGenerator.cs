namespace Servicios.Interfaces;

public interface IPdfReport
{
    TypeReport Type => TypeReport.Pdf;
    void Generate(IReport report);
}