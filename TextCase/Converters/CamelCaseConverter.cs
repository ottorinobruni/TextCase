using System;
using System.Text;
using TextCase.Extensions;

namespace TextCase.Converters
{
    // <summary>
    //// Represents a camel converter
    /// </summary>
    public class CamelCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified text to camel case.
        /// </summary>
        /// <param name="text">The string to convert to camel case.</param>
        /// <returns>The specified text converted to camel case.</returns>
        public string Convert(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            var builder = new StringBuilder();
            var words = text.Split(' ');
            var isFirstTime = true;
            foreach (var word in words)
            {
                if (!String.IsNullOrEmpty(word))
                {
                    builder.Append(isFirstTime ? word.ToLowerInvariant(): word.ToFirstLetterUpperCase());
                    isFirstTime = false;
                }
            }
            return builder.ToString().Replace(" ", "");
        }
    }
}
