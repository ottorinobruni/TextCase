using System.Text;

namespace TextCase.Converters
{
    /// <summary>
    /// Represents a base64 encode converter.
    /// </summary>
    public class Base64EncodeCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified text to base64 encode.
        /// </summary>
        /// <param name="text">The string to convert to base64 encode.</param>
        /// <returns>The specified text converted to base64 encode.</returns>
        public string Convert(string text)
        {
            return string.IsNullOrWhiteSpace(text) ? 
                string.Empty : 
                System.Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
        }
    }

}
