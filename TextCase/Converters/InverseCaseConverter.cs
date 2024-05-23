using System;
using System.Globalization;
using System.Text;
using TextCase.Extensions;

namespace TextCase.Converters
{
    /// <summary>
    /// Represents an inverse converter
    /// </summary>
    public class InverseCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified text to inverse case.
        /// </summary>
        /// <param name="text">The string to convert to inverse case.</param>
        /// <returns>The specified text converted to inverse case.</returns>
        public string Convert(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return string.Empty;
            }

            var builder = new StringBuilder();
            var isUpper = false;

            foreach (var c in text)
            {
                builder.Append(isUpper ? char.ToUpperInvariant(c) : char.ToLowerInvariant(c));
                if (!char.IsWhiteSpace(c))
                {
                    isUpper = !isUpper;
                }
            }

            return builder.ToString();
        }
    }
}
