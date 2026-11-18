using System.Threading.Tasks;

namespace TextEditor.Core.Interfaces;
public interface IFileService
{
    /// <summary>
    /// Reads the whole file asynchronously as UTF-8 text.
    /// Errors (missing file, no permission, I/O) are thrown to the caller.
    /// </summary>
    Task<string> ReadAsync(string path);
}