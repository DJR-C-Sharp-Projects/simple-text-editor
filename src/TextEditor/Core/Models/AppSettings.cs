using TextEditor.Core.Enums;

namespace TextEditor.Models;

/// <summary>
/// Represents the user preferences used by the text editor.
/// </summary>
public sealed class AppSettings
{
    /// <summary>
    /// Defines the default zoom factor.
    /// <exemple>A value of 1.0 represents 100% of the original size.</exemple>
    /// </summary>
    public const double DefaultZoom = 1.0;

    /// <summary>
    /// Gets or sets the application theme preference.
    /// </summary>
    public AppTheme Theme { get; set; } = AppTheme.System;

    /// <summary>
    /// Gets or sets the text zoom factor.
    /// <exemple>A value of 1.5 represents 150% and 0.75 represents 75%.</exemple>
    /// </summary>
    public double Zoom { get; set; } = DefaultZoom;

    /// <summary>
    /// Gets or sets a value indicating whether long lines should wrap
    /// instead of requiring horizontal scrolling.
    /// </summary>
    public bool WordWrap { get; set; } = true;
}