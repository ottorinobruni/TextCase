using System;
using System.Globalization;
using System.Text;
using TextCase.Extensions;

namespace TextCase.Converters
{
    // <summary>
    //// Represents a title converter
    /// </summary>
    public class AlternateCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified text to alternate case.
        /// </summary>
        /// <param name="text">The string to convert to alternate case.</param>
        /// <returns>The specified text converted to alternate case.</returns>
        public string Convert(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            var builder = new StringBuilder();
            var isFirst = true;

            for (int i = 0; i < text.Length; i++)
            {
                if (!String.IsNullOrWhiteSpace(text[i].ToString()))
                {
                    builder.Append((isFirst) ? text[i].ToString().ToUpperInvariant() : text[i].ToString().ToLowerInvariant());
                    isFirst = !isFirst;
                }
                else
                {
                    builder.Append(' ');
                }
            }
            return builder.ToString();
        }
    }
}
