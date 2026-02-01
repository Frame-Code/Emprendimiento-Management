using Azure;
using Servicios.Interfaces;
using Shared;

namespace Servicios.Impl;

/// <summary>
/// Implementación de utilidades de archivos: lectura de metadatos y copia segura al almacén local.
/// </summary>
public class FileServiceImpl : IFileService
{
    private readonly string _imagesRoot;
    public FileServiceImpl()
    {
        var appRoot =  Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "ProyectoFinal"
        );
        _imagesRoot = Path.Combine(appRoot, "Images");
    }

    /// <inheritdoc />
    public ResponseDto GetFileInfo(string path)
    {
        if (string.IsNullOrWhiteSpace(path))
            return new ResponseDto
            {
                IsSuccess = false,
                Message = "Path no puede ser vacio"
            };

        if (!File.Exists(path))
            return new ResponseDto
            {
                IsSuccess = false,
                Message = "El archivo no se ha encontrado"
            };

        var file = new FileDto()
        {
            FileName = Path.GetFileNameWithoutExtension(path),
            FileExtension = Path.GetExtension(path),
            Url = path
        };
        return new ResponseDto
        {
            IsSuccess = true,
            Message = "Archivo procesado",
            Data = file
        };
    }

    /// <inheritdoc />
    public ResponseDto CopyFile(string path)
    {
        if (string.IsNullOrWhiteSpace(path))
            return new ResponseDto
            {
                IsSuccess = false,
                Message = "El path de origen no puede ser vacío"
            };

        if (!File.Exists(path))
            return new ResponseDto
            {
                IsSuccess = false,
                Message = "El archivo de origen no existe"
            };
        
        var ext = Path.GetExtension(path);
        var fileNameNoExt = Path.GetFileNameWithoutExtension(path);
        
        Directory.CreateDirectory(_imagesRoot);
        
        var unique = $"{DateTime.Now:yyyyMMdd_HHmmss}_{Guid.NewGuid():N}".Substring(0, 4 + 32); 
        var storedFileName = $"{fileNameNoExt}_{DateTime.Now:yyyyMMdd_HHmmss}_{Guid.NewGuid():N}{ext}";
        var destPath = Path.Combine(_imagesRoot, storedFileName);

        File.Copy(path, destPath, overwrite: false);
        
        var file = new FileDto()
        {
            FileName = Path.GetFileNameWithoutExtension(path),
            FileExtension = Path.GetExtension(path),
            Url = destPath
        };
        
        return new ResponseDto
        {
            IsSuccess = true,
            Message = "Archivo copiado correctamente",
            Data = file
        };
    }
}
