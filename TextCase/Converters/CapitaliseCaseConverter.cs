using System;
using System.Globalization;

namespace TextCase.Converters
{
    // <summary>
    //// Represents a uppercase converter
    /// </summary>
    public class CapitaliseCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified text to capitalise case.
        /// </summary>
        /// <param name="text">The string to convert to capitalise case.</param>
        /// <returns>The specified text converted to capitalise case.</returns>
        public string Convert(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            var firstPart = text.Trim().Substring(0, 1).ToUpperInvariant();
            var secondPart = text.Trim().Length > 1 ? text.Trim()[1..].ToLowerInvariant() : "";
            return String.Format("{0}{1}", firstPart, secondPart);
        }
    }
}
