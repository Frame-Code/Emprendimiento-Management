using Shared;

namespace Servicios.Interfaces;

public interface IFileService
{
    ResponseDto GetFileInfo(string path);
    ResponseDto CopyFile(string path);
}