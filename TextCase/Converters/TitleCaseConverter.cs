using System;
using System.Globalization;

namespace TextCase.Converters
{
    // <summary>
    //// Represents a title converter
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
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }
            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(text);
        }
    }
}
