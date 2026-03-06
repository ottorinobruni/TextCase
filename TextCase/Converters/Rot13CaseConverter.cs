using System.Text;

namespace TextCase.Converters
{
    /// <summary>
    /// Represents a ROT13 cipher converter
    /// </summary>
    public class Rot13CaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified text using the ROT13 substitution cipher.
        /// </summary>
        /// <param name="text">The string to convert using ROT13.</param>
        /// <returns>The specified text converted using ROT13.</returns>
        public string Convert(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return string.Empty;
            }

            var result = new StringBuilder(text.Length);
            foreach (var c in text)
            {
                if (c >= 'a' && c <= 'z')
                    result.Append((char)('a' + (c - 'a' + 13) % 26));
                else if (c >= 'A' && c <= 'Z')
                    result.Append((char)('A' + (c - 'A' + 13) % 26));
                else
                    result.Append(c);
            }
            return result.ToString();
        }
    }
}
