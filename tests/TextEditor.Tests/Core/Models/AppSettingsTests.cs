using TextEditor.Core.Enums;
using TextEditor.Models;

namespace TextEditor.UnitTests.Core.Models;

public class AppSettingsTests
{
    private const double Zoom150Percent = 1.5;
    private const double Zoom75Percent = 0.75;
    private const double Zoom200Percent = 2.0;

    [Fact(DisplayName = "Default settings use the expected default values")]
    public void DefaultSettings_UseDefaultValues()
    {
        var settings = new AppSettings();

        Assert.Equal(AppTheme.System, settings.Theme);
        Assert.Equal(AppSettings.DefaultZoom, settings.Zoom);
        Assert.True(settings.WordWrap);
    }

    [Theory(DisplayName = "Settings properties accept assigned values")]
    [InlineData(AppTheme.Dark, Zoom150Percent, false)]
    [InlineData(AppTheme.Light, Zoom75Percent, true)]
    [InlineData(AppTheme.System, Zoom200Percent, false)]
    public void Properties_AcceptAssignedValues(
        AppTheme theme,
        double zoom,
        bool wordWrap)
    {
        var settings = new AppSettings
        {
            Theme = theme,
            Zoom = zoom,
            WordWrap = wordWrap
        };

        Assert.Equal(theme, settings.Theme);
        Assert.Equal(zoom, settings.Zoom);
        Assert.Equal(wordWrap, settings.WordWrap);
    }
}