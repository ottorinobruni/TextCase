using System.Text.RegularExpressions;

namespace TextCase.Converters
{
    /// <summary>
    /// Represents a dot case converter
    /// </summary>
    public class DotCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified text to dot case.
        /// </summary>
        /// <param name="text">The string to convert to dot case.</param>
        /// <returns>The specified text converted to dot case.</returns>
        public string Convert(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return string.Empty;
            }

            var regex = new Regex(@"[ \-_=]+");
            var result = regex.Replace(text.Trim().ToLowerInvariant(), ".");

            return result.Trim('.');
        }
    }
}
