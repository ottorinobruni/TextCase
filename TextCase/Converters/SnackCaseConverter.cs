using System;
using System.Text;
using TextCase.Extensions;

namespace TextCase.Converters
{
    /// <summary>
    /// Represents a snack converter
    /// </summary>
    public class SnackCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified text to snack case.
        /// </summary>
        /// <param name="text">The string to convert to snack case.</param>
        /// <returns>The specified text converted to snack case.</returns>
        public string Convert(string text)
        {
            return string.IsNullOrWhiteSpace(text) ? 
                string.Empty : 
                text.ToLowerInvariant().Replace(" ", "_");
        }
    }
}
