using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCase.Converters
{
    using System;
    using System.Text.RegularExpressions;

    namespace TextCase.Converters
    {
        /// <summary>
        /// Represents a constant case converter
        /// </summary>
        public class ConstantCaseConverter : ICaseConverter
        {
            /// <summary>
            /// Converts the specified text to constant case.
            /// </summary>
            /// <param name="text">The string to convert to constant case.</param>
            /// <returns>The specified text converted to constant case.</returns>
            public string Convert(string text)
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    return string.Empty;
                }
                // Split by newline characters to handle each line separately
                var lines = text.Split('\n');

                for (int i = 0; i < lines.Length; i++)
                {
                    // Remove characters that are not letters, digits, spaces, or underscores
                    var cleanedLine = Regex.Replace(lines[i], @"[^\w\s-]", string.Empty);

                    // Replace spaces and dashes with underscores
                    var withUnderscores = cleanedLine.Replace(' ', '_').Replace('-', '_');

                    // Convert to uppercase
                    lines[i] = withUnderscores.ToUpperInvariant();
                }

                // Join the lines back with newline characters
                return string.Join('\n', lines);
            }
        }
    }

}
