using System;
namespace TextCase.Converters
{
    /// <summary>
    /// Represents a lowercase converter
    /// </summary>
    public class LowerCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified string to lowercase using the casing rules of the invariant culture.
        /// </summary>
        /// <param name="text">The string to convert to lowercase case.</param>
        /// <returns>The specified text converted to lowercase case.</returns>
        public string Convert(string text)
        {
            return string.IsNullOrWhiteSpace(text) ? 
                string.Empty : 
                text.ToLowerInvariant();
        }
    }
}
