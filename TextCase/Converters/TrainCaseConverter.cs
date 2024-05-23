using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextCase.Converters
{
    /// <summary>
    /// Represents a train case converter
    /// </summary>
    public class TrainCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified text to train case.
        /// </summary>
        /// <param name="text">The string to convert to train case.</param>
        /// <returns>The specified text converted to train case.</returns>
        public string Convert(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return string.Empty;
            }

            // Replace one or more consecutive non-letter, non-digit, non-newline characters with a single dash
            var replacedPunctuation = Regex.Replace(text, @"[^\p{L}0-9\n]+", "-");

            // Split the text into lines
            var lines = replacedPunctuation.Split('\n');

            // Convert each line to title case and trim leading and trailing dashes
            var processedLines = lines.Select(line => CultureInfo.InvariantCulture.TextInfo.ToTitleCase(line.ToLowerInvariant()).Trim('-'));

            // Join the lines back together
            return string.Join("\n", processedLines);
        }
    }
}
