
namespace TextEditor.Core.Models;

/// <summary>
/// Represents the options for finding text.
/// </summary>
public class FindOptions
{

    /// <summary>
    /// Gets or sets a value indicating whether to match the case.
    /// </summary>
    public bool MatchCase { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether to match the whole word.
    /// </summary>
    public bool WholeWord { get; set; } = false;

}
