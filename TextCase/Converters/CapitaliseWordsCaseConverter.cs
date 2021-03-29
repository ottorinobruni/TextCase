using System;
using System.Globalization;
using TextCase.Extensions;

namespace TextCase.Converters
{
    // <summary>
    //// Represents a capitalise converter
    /// </summary>
    public class CapitaliseWordsCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified text to capitalise words case.
        /// </summary>
        /// <param name="text">The string to convert to capitalise words case.</param>
        /// <returns>The specified text converted to capitalise words case.</returns>
        public string Convert(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            return text.ToLowerInvariant().ToTitleCase();
        }
    }
}
