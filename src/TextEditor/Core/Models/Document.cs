using System;
using System.Collections.Generic;
using System.Text;

namespace TextEditor.Core.Models
{
    /// <summary>
    /// Stable metadata of a document: file path, name and encoding.
    /// Does not hold modification state (source of truth: DocumentViewModel.IsModified).
    /// </summary>
    public class Document
    {
        public const string DefaultName = "Untitled";

        /// <summary>Path of the file on disk. Null until the document is first saved.</summary>
        public string? FilePath { get; set; }

        /// <summary>Name shown on the tab and in the window title.</summary>
        public string Name { get; set; } = DefaultName;

        /// <summary>Encoding used for reading and writing. MVP default: UTF-8.</summary>
        public Encoding Encoding { get; set; } = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);
    }
}