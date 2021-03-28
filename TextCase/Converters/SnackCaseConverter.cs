using System;
using System.Text;
using TextCase.Extensions;

namespace TextCase.Converters
{
    // <summary>
    //// Represents a snack converter
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
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            var result = text.ToLowerInvariant();
            return result.Replace(" ", "_");
        }
    }
}
