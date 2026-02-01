using Shared;

namespace Servicios.Interfaces;

/// <summary>
/// Servicios utilitarios para manejo básico de archivos locales.
/// </summary>
public interface IFileService
{
    /// <summary>Obtiene metadatos de un archivo en disco.</summary>
    /// <param name="path">Ruta absoluta del archivo.</param>
    ResponseDto GetFileInfo(string path);

    /// <summary>Copia un archivo al directorio de imágenes de la aplicación.</summary>
    /// <param name="path">Ruta de origen del archivo.</param>
    ResponseDto CopyFile(string path);
}
