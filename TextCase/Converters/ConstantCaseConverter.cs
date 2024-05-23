using System.Linq;
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

            // Replace one or more consecutive non-alphanumeric characters (except newlines) with a single underscore
            var replacedPunctuation = Regex.Replace(text, @"[^\w\n]+", "_");

            // Split the text into lines
            var lines = replacedPunctuation.Split('\n');

            // Convert each line to upper case and trim leading and trailing underscores
            var processedLines = lines.Select(line => line.Trim().ToUpperInvariant().Trim('_'));

            // Join the lines back together
            return string.Join("\n", processedLines);
        }
    }
}
