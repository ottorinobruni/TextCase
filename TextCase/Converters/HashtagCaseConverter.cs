using System;
using System.Text;

namespace TextCase.Converters
{
    /// <summary>
    /// Represents a hash-tag converter
    /// </summary>
    public class HashTagCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified text to hash-tag case.
        /// </summary>
        /// <param name="text">The string to convert to hash-tag case.</param>
        /// <returns>The specified text converted to hash-tag case.</returns>
        public string Convert(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return string.Empty;
            }

            var lines = text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                var words = lines[i].Split(new[] { ' ', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                if (words.Length > 0)
                {
                    lines[i] = "#" + string.Join(" #", words);
                }
            }

            return string.Join(Environment.NewLine, lines);
        }
    }

}
