using TextEditor.Core.Enums;

namespace TextEditor.Models;

public sealed class AppSettings
{
    public const double DefaultZoom = 1.0;

    public AppTheme Theme { get; set; } = AppTheme.System;

    public double Zoom { get; set; } = DefaultZoom;

    public bool WordWrap { get; set; } = true;
}