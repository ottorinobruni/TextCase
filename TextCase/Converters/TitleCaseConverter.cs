using System;
using System.Globalization;
using TextCase.Extensions;

namespace TextCase.Converters
{
    /// <summary>
    /// Represents a title converter
    /// </summary>
    public class TitleCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified text to title case.
        /// </summary>
        /// <param name="text">The string to convert to title case.</param>
        /// <returns>The specified text converted to title case.</returns>
        public string Convert(string text)
        {

            return string.IsNullOrWhiteSpace(text) ? 
                string.Empty : 
                text.ToTitleCase();
        }
    }
}