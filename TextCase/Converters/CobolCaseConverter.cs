using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TextCase.Converters
{
    /// <summary>
    /// Represents a cobol case converter
    /// </summary>
    public class CobolCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified text to constant case.
        /// </summary>
        /// <param name="text">The string to convert to cobol case.</param>
        /// <returns>The specified text converted to cobol case.</returns>
        public string Convert(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return string.Empty;
            }

            // Replace one or more consecutive non-letter, non-digit, non-newline characters with a single dash
            var replacedPunctuation = Regex.Replace(text, @"[^\p{L}0-9" + Environment.NewLine + "]+", "-");

            // Split the text into lines
            var lines = replacedPunctuation.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            // Convert each line to upper case and trim leading and trailing dashes
            var processedLines = lines.Select(line => line.Trim().ToUpperInvariant().Trim('-'));

            // Join the lines back together
            return string.Join(Environment.NewLine, processedLines);
        }
    }
}
