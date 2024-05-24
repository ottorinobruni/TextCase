using System;
using System.Text;

namespace TextCase.Converters
{
    /// <summary>
    /// Represents a base64 decode converter.
    /// </summary>
    public class Base64DecodeCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified text to base64 decode.
        /// </summary>
        /// <param name="text">The string to convert to base64 decode.</param>
        /// <returns>The specified text converted to base64 decode.</returns>
        public string Convert(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            try
            {
                return Encoding.UTF8.GetString(System.Convert.FromBase64String(text));
            }
            catch (FormatException)
            {
                return text;
            }
        }
    }

}
