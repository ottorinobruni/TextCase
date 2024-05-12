using System;
using System.Text;

namespace TextCase.Converters
{
    /// <summary>
    /// Represents a hashtag converter
    /// </summary>
    public class HashtagCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified text to hashtag case.
        /// </summary>
        /// <param name="text">The string to convert to hashtag case.</param>
        /// <returns>The specified text converted to hashtag case.</returns>
        public string Convert(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return string.Empty;
            }

            var words = text.Split(new[] { ' ', '\t', '\n', '\r' }, 
                StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                return string.Empty;
            }

            return "#" + string.Join(" #", words);
        }
    }

}
