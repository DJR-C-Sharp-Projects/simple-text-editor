using System.Text;
using NotepadApp.Infrastructure;
using Xunit;

namespace NotepadApp.Tests.Infrastructure;

[Trait("Layer", "Infrastructure")]
[Trait("Component", "FileService")]
public class FileServiceTests : IDisposable
{
    private readonly string _tempDir;
    private readonly FileService _sut = new();

    public FileServiceTests()
    {
        _tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_tempDir);
    }

    public void Dispose() => Directory.Delete(_tempDir, recursive: true);

    [Fact(DisplayName = "ReadAsync: existing file returns its content as UTF-8")]
    [Trait("Scenario", "Existing file")]
    public async Task ReadAsync_ExistingFile_ReturnsContentInUtf8()
    {
        var path = Path.Combine(_tempDir, "existing.txt");
        const string expected = "Hello, world! áéíóú ção 日本語";
        await File.WriteAllTextAsync(path, expected, new UTF8Encoding(false));

        var result = await _sut.ReadAsync(path);

        Assert.Equal(expected, result);
    }

    [Fact(DisplayName = "ReadAsync: missing file throws FileNotFoundException")]
    [Trait("Scenario", "Missing file")]
    public async Task ReadAsync_MissingFile_ThrowsFileNotFoundException()
    {
        var path = Path.Combine(_tempDir, "missing.txt");

        await Assert.ThrowsAsync<FileNotFoundException>(() => _sut.ReadAsync(path));
    }

    [Fact(DisplayName = "ReadAsync: empty file returns an empty string")]
    [Trait("Scenario", "Empty file")]
    public async Task ReadAsync_EmptyFile_ReturnsEmptyString()
    {
        var path = Path.Combine(_tempDir, "empty.txt");
        await File.WriteAllTextAsync(path, string.Empty);

        var result = await _sut.ReadAsync(path);

        Assert.Equal(string.Empty, result);
    }
}