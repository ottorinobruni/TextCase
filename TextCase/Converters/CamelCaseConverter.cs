using System;
using System.Globalization;
using System.Text;
using TextCase.Extensions;

namespace TextCase.Converters
{
    /// <summary>
    /// Represents a camel converter
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
            if (string.IsNullOrWhiteSpace(text))
            {
                return string.Empty;
            }

            var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                return string.Empty;
            }

            var builder = new StringBuilder(words[0].ToLowerInvariant());

            for (int i = 1; i < words.Length; i++)
            {
                builder.Append(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(words[i].ToLowerInvariant()));
            }

            return builder.ToString();
        }
    }

}
