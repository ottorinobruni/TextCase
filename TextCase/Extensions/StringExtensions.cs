using System;
using System.Globalization;

namespace TextCase.Extensions
{
    public static class StringExtensions
    {
        internal static string ToFirstLetterUpperCase(this string value)
        {
            var firstPart = value.Trim().Substring(0, 1).ToUpperInvariant();
            var secondPart = value.Trim().Length > 1 ? value.Trim()[1..].ToLowerInvariant() : "";
            return String.Format("{0}{1}", firstPart, secondPart);
        }

        internal static string ToTitleCase(this string value)
        {
            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(value);
        }

        /// <summary>
        /// Gets the number of characters in the current String value.
        /// </summary>
        /// <param name="value">The string to count.</param>
        /// <returns>The number of characters in the current string.</returns>
        internal static int GetTextCount(this string value)
        {
            return (String.IsNullOrEmpty(value)) ? 0 : value.Length;
        }

    }
}
