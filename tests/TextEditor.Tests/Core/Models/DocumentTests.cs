using System.Text;
using TextEditor.Core.Models;
using Xunit;

namespace TextEditor.UnitTests.Core.Models;

public class DocumentTests
{
    [Fact(DisplayName = "New document: FilePath starts as null")]
    public void NewDocument_FilePath_IsNull()
    {
        var document = new Document();

        Assert.Null(document.FilePath);
    }

    [Fact(DisplayName = "New document: Name starts as the default name")]
    public void NewDocument_Name_IsDefaultName()
    {
        var document = new Document();

        Assert.Equal(Document.DefaultName, document.Name);
    }

    [Fact(DisplayName = "New document: Encoding is UTF-8")]
    public void NewDocument_Encoding_IsUtf8()
    {
        var document = new Document();

        Assert.Equal(Encoding.UTF8.CodePage, document.Encoding.CodePage);
    }

    [Fact(DisplayName = "New document: Encoding does not emit a BOM")]
    public void NewDocument_Encoding_DoesNotEmitBom()
    {
        var document = new Document();

        Assert.Empty(document.Encoding.GetPreamble());
    }

    [Fact(DisplayName = "Properties accept new values")]
    public void Properties_CanBeUpdated()
    {
        var document = new Document
        {
            FilePath = "/tmp/nota.txt",
            Name = "nota.txt",
            Encoding = Encoding.ASCII
        };

        Assert.Equal("/tmp/nota.txt", document.FilePath);
        Assert.Equal("nota.txt", document.Name);
        Assert.Equal(Encoding.ASCII, document.Encoding);
    }
}