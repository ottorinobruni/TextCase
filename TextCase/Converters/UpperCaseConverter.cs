using System;
namespace TextCase.Converters
{
    // <summary>
    //// Represents a uppercase converter
    /// </summary>
    public class UpperCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Returns a string converted to uppercase using the casing rules of the invariant culture.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string Convert(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }
            return text.ToUpperInvariant();
        }
    }
}
