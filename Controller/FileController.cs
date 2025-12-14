using Servicios.Interfaces;
using Shared;

namespace Controller;

public class FileController(IFileService service)
{
    public ResponseDto GetFileInfo(string path) =>
        service.GetFileInfo(path);

    public ResponseDto CopyFile(string path) =>
        service.CopyFile(path);
}