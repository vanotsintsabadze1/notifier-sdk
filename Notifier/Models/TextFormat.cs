namespace Notifier.Models;

/// <summary>
/// Specifies the format of text content in an email message.
/// </summary>
public enum TextFormat
{
    /// <summary>
    /// The plain text format.
    /// </summary>
    Plain,

    /// <summary>
    /// An alias for the plain text format.
    /// </summary>
    Text = Plain,

    /// <summary>
    /// The flowed text format (as described in rfc3676).
    /// </summary>
    Flowed,

    /// <summary>
    /// The HTML text format.
    /// </summary>
    Html,

    /// <summary>
    /// The enriched text format.
    /// </summary>
    Enriched,

    /// <summary>
    /// The compressed rich text format.
    /// </summary>
    CompressedRichText,

    /// <summary>
    /// The rich text format.
    /// </summary>
    RichText,
}
