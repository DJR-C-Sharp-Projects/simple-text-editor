using TextEditor.Core.Models;


namespace TextEditor.UnitTests.Core.Models;

public class FindOptionsTests
{
    [Fact(DisplayName = "Default settings use the expected default values")]
    public void DefaultSettings_UseDefaultValues()
    {
        var settings = new FindOptions();

        Assert.False(settings.MatchCase);
        Assert.False(settings.WholeWord);
    }
}
