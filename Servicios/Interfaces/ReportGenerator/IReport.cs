namespace Servicios.Interfaces;

public interface IReport
{
    TypeReport Report { get; }
    Task Export(string reportName, object data);
}