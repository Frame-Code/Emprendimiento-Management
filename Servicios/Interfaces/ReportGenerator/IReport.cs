namespace Servicios.Interfaces;

public interface IReport
{
    void Export(string name);
    TypeReport Type { get; } 
}