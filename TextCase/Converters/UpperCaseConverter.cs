using System;
namespace TextCase.Converters
{
    /// <summary>
    /// Represents a uppercase converter
    /// </summary>
    public class UpperCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified string to uppercase using the casing rules of the invariant culture.
        /// </summary>
        /// <param name="text">The string to convert to uppercase case.</param>
        /// <returns>The specified text converted to uppercase case.</returns>
        public string Convert(string text)
        {
            return string.IsNullOrWhiteSpace(text) ? 
                string.Empty : 
                text.ToUpperInvariant();
        }
    }
}
