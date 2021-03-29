using System;
namespace TextCase.Converters
{
    // <summary>
    //// Represents a reverse converter
    /// </summary>
    public class ReverseCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified string to reverse case
        /// </summary>
        /// <param name="text">The string to convert to reverse case.</param>
        /// <returns>The specified text converted to reverse case.</returns>
        public string Convert(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
