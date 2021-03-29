using System;
using System.Text;
using TextCase.Extensions;

namespace TextCase.Converters
{
    // <summary>
    //// Represents a pascal converter
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
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            var result = text.ToTitleCase();
            return result.ToString().Replace(" ", "");
        }
    }
}
