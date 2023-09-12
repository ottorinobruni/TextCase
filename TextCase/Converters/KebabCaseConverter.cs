using System;
using System.Text;
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
            return string.IsNullOrEmpty(text) ?
                string.Empty :
                text.ToLowerInvariant().Replace(" ", "-");
        }
    }
}
