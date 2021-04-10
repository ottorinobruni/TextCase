using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

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
            if (string.IsNullOrEmpty(value))
            {
                return 0;
            }
            return value.Length;
        }

        /// <summary>
        /// Gets the number of words in the current String value.
        /// </summary>
        /// <param name="value">The string to count.</param>
        /// <returns>The number of words in the current string.</returns>
        internal static int GetWordsCount(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return 0;
            }
            return Regex.Replace(value, "[^a-zA-Z0-9_]+", " ")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Length;
        }

        /// <summary>
        /// Gets the number of letters in the current String value.
        /// </summary>
        /// <param name="value">The string to count.</param>
        /// <returns>The number of letters in the current string.</returns>
        internal static int GetLettersCount(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return 0;
            }
            return value.Count(char.IsLetter);
        }

        /// <summary>
        /// Gets the number of sentences in the current String value.
        /// </summary>
        /// <param name="value">The string to count.</param>
        /// <returns>The number of sentences in the current string.</returns>
        internal static int GetSentencesCount(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return 0;
            }
            return value.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

    }
}
