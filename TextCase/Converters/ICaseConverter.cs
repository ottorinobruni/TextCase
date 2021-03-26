using System;
namespace TextCase.Converters
{
    /// <summary>
    /// Interface for Case Converter
    /// </summary>
    public interface ICaseConverter
    {
        /// <summary>
        /// Converts a text to a string
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        string Convert(string text);
    }
}
