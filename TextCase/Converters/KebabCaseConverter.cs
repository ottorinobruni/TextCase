using System;
using System.Text;
using TextCase.Extensions;

namespace TextCase.Converters
{
    // <summary>
    //// Represents a kebab converter
    /// </summary>
    public class KebabCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified text to kebab case.
        /// </summary>
        /// <param name="text">The string to convert to kebab case.</param>
        /// <returns>The specified text converted to kebab case.</returns>
        public string Convert(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            var result = text.ToLowerInvariant();
            return result.Replace(" ", "-");
        }
    }
}
