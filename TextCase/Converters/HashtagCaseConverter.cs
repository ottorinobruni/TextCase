using System;
using System.Text;
using TextCase.Extensions;

namespace TextCase.Converters
{
    // <summary>
    //// Represents a hashtag converter
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
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            var builder = new StringBuilder();
            var words = text.Split(' ');
            foreach (var word in words)
            {
                if (!String.IsNullOrEmpty(word))
                {
                    builder.Append($"#{word} ");
                }
            }
            return builder.ToString().Trim();
        }
    }
}
