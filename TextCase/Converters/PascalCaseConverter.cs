using System;
using System.Globalization;
using System.Text;
using TextCase.Extensions;

namespace TextCase.Converters
{
    /// <summary>
    /// Represents a pascal converter
    /// </summary>
    public class PascalCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified text to pascal case.
        /// </summary>
        /// <param name="text">The string to convert to pascal case.</param>
        /// <returns>The specified text converted to pascal case.</returns>
        public string Convert(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return string.Empty;
            }

            text = text.Replace("\n", " ").Replace("\t", " ");
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLowerInvariant()).Replace(" ", "");
        }
    }
}
