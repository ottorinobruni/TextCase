using System;
using System.Text;
using System.Text.RegularExpressions;
using TextCase.Extensions;

namespace TextCase.Converters
{
    /// <summary>
    /// Represents a kebab converter
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
            if (string.IsNullOrWhiteSpace(text))
            {
                return string.Empty;
            }

            // Replace spaces, equals signs, and underscores with hyphens
            var regex = new Regex(@"[ =_]+");
            var result = regex.Replace(text.Trim().ToLowerInvariant(), "-");

            // Remove leading and trailing hyphens
            return result.Trim('-');
        }
    }
}
