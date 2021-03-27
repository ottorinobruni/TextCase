using System;
namespace TextCase.Converters
{
    /// <summary>
    /// Interface for Case Converter
    /// </summary>
    public interface ICaseConverter
    {
        /// <summary>
        /// Converts the specified string to a string.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        string Convert(string text);
    }
}
