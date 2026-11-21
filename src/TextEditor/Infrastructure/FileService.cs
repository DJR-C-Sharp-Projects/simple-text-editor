using System.IO;
using System.Text;
using System.Threading.Tasks;
using TextEditor.Core.Interfaces;

namespace TextEditor.Core.Infrastructure;

public class FileService : IFileService
{
    public Task<string> ReadAsync(string path)
    {
        // No try/catch on purpose: FileNotFoundException, DirectoryNotFoundException,
        // UnauthorizedAccessException and IOException propagate to the caller.
        return File.ReadAllTextAsync(path, Encoding.UTF8);
    }
}