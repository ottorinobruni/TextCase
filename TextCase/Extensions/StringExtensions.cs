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

            var trimmedValue = value.Trim();
            var firstPart = trimmedValue.Substring(0, 1).ToUpperInvariant();
            var secondPart = trimmedValue.Length > 1 ? trimmedValue[1..].ToLowerInvariant() : "";
            return String.Format("{0}{1}", firstPart, secondPart);
        }
        
        /// <summary>
        /// Gets the number of characters in the current String value.
        /// </summary>
        /// <param name="value">The string to count.</param>
        /// <returns>The number of characters in the current string.</returns>
        public static int GetTextCount(this string value)
        {
            return value?.Length ?? 0;
        }

        /// <summary>
        /// Gets the number of words in the current String value.
        /// </summary>
        /// <param name="value">The string to count.</param>
        /// <returns>The number of words in the current string.</returns>
        public static int GetWordsCount(this string value)
        {
            return string.IsNullOrEmpty(value) ? 0 : value.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        /// <summary>
        /// Gets the number of letters in the current String value.
        /// </summary>
        /// <param name="value">The string to count.</param>
        /// <returns>The number of letters in the current string.</returns>
        public static int GetLettersCount(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
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
        public static int GetSentencesCount(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return 0;
            }

            // Split sentences based on common sentence-ending punctuation marks.
            var sentenceSeparators = new char[] { '.', '!', '?' };
            var sentences = value.Split(sentenceSeparators, StringSplitOptions.RemoveEmptyEntries)
                .Where(sentence => !string.IsNullOrWhiteSpace(sentence))
                .ToArray();

            return sentences.Length;
        }
        
        /// <summary>
        /// Converts the specified string to uppercase using the casing rules of the invariant culture.
        /// </summary>
        /// <param name="value">The string to convert to uppercase case.</param>
        /// <returns>The specified text converted to uppercase case.</returns>
        public static string ToUpperCase(this string value)
        {
            return TextCase.Convert(value, Case.UpperCase);
        }

        /// <summary>
        /// Converts the specified string to lowercase using the casing rules of the invariant culture.
        /// </summary>
        /// <param name="value">The string to convert to lowercase case.</param>
        /// <returns>The specified text converted to lowercase case.</returns>
        public static string ToLowerCase(this string value)
        {
            return TextCase.Convert(value, Case.LowerCase);
        }

        /// <summary>
        /// Converts the specified text to title case.
        /// </summary>
        /// <param name="value">The string to convert to title case.</param>
        /// <returns>The specified text converted to title case.</returns>
        public static string ToTitleCase(this string value)
        {
            return TextCase.Convert(value, Case.TitleCase);
        }

        /// <summary>
        /// Converts the specified text to capitalize case.
        /// </summary>
        /// <param name="value">The string to convert to capitalize case.</param>
        /// <returns>The specified text converted to capitalize case.</returns>
        public static string ToCapitalizeCase(this string value)
        {
            return TextCase.Convert(value, Case.CapitalizeCase);
        }

        /// <summary>
        /// Converts the specified text to capitalize words case.
        /// </summary>
        /// <param name="value">The string to convert to capitalize words case.</param>
        /// <returns>The specified text converted to capitalize words case.</returns>
        public static string ToCapitalizeWordsCase(this string value)
        {
            return TextCase.Convert(value, Case.CapitalizeWordsCase);
        }

        /// <summary>
        /// Converts the specified string to reverse case
        /// </summary>
        /// <param name="value">The string to convert to reverse case.</param>
        /// <returns>The specified text converted to reverse case.</returns>
        public static string ToReverseCase(this string value)
        {
            return TextCase.Convert(value, Case.ReverseCase);
        }

        /// <summary>
        /// Converts the specified text to alternate case.
        /// </summary>
        /// <param name="value">The string to convert to alternate case.</param>
        /// <returns>The specified text converted to alternate case.</returns>
        public static string ToAlternateCase(this string value)
        {
            return TextCase.Convert(value, Case.AlternateCase);
        }

        /// <summary>
        /// Converts the specified text to camel case.
        /// </summary>
        /// <param name="value">The string to convert to camel case.</param>
        /// <returns>The specified text converted to camel case.</returns>
        public static string ToCamelCase(this string value)
        {
            return TextCase.Convert(value, Case.CamelCase);
        }

        /// <summary>
        /// Converts the specified text to pascal case.
        /// </summary>
        /// <param name="value">The string to convert to pascal case.</param>
        /// <returns>The specified text converted to pascal case.</returns>
        public static string ToPascalCase(this string value)
        {
            return TextCase.Convert(value, Case.PascalCase);
        }

        /// <summary>
        /// Converts the specified text to kebab case.
        /// </summary>
        /// <param name="value">The string to convert to kebab case.</param>
        /// <returns>The specified text converted to kebab case.</returns>
        public static string ToKebabCase(this string value)
        {
            return TextCase.Convert(value, Case.KebabCase);
        }

        /// <summary>
        /// Converts the specified text to snack case.
        /// </summary>
        /// <param name="value">The string to convert to snack case.</param>
        /// <returns>The specified text converted to snack case.</returns>
        public static string ToSnackCase(this string value)
        {
            return TextCase.Convert(value, Case.SnackCase);
        }

        /// <summary>
        /// Converts the specified text to hashtag case.
        /// </summary>
        /// <param name="value">The string to convert to hashtag case.</param>
        /// <returns>The specified text converted to hashtag case.</returns>
        public static string ToHashTagCase(this string value)
        {
            return TextCase.Convert(value, Case.HashTagCase);
        }

        /// <summary>
        /// Converts the specified text to constant case.
        /// </summary>
        /// <param name="value">The string to convert to constant case.</param>
        /// <returns>The specified text converted to constant case.</returns>
        public static string ToConstantCase(this string value)
        {
            return TextCase.Convert(value, Case.ConstantCase);
        }

        /// <summary>
        /// Converts the specified text to cobol case.
        /// </summary>
        /// <param name="value">The string to convert to cobol case.</param>
        /// <returns>The specified text converted to cobol case.</returns>
        public static string ToCobolCase(this string value)
        {
            return TextCase.Convert(value, Case.CobolCase);
        }

        /// <summary>
        /// Converts the specified text to inverse case.
        /// </summary>
        /// <param name="value">The string to convert to inverse case.</param>
        /// <returns>The specified text converted to inverse case.</returns>
        public static string ToInverseCase(this string value)
        {
            return TextCase.Convert(value, Case.InverseCase);
        }

        /// <summary>
        /// Converts the specified text to train case.
        /// </summary>
        /// <param name="value">The string to convert to train case.</param>
        /// <returns>The specified text converted to train case.</returns>
        public static string ToTrainCase(this string value)
        {
            return TextCase.Convert(value, Case.TrainCase);
        }

        /// <summary>
        /// Converts the specified text to base64 decode case.
        /// </summary>
        /// <param name="value">The string to convert to base64 decode case.</param>
        /// <returns>The specified text converted to base64 decode case.</returns>
        public static string ToBase64DecodeCase(this string value)
        {
            return TextCase.Convert(value, Case.Base64DecodeCase);
        }

        /// <summary>
        /// Converts the specified text to base64 encode case.
        /// </summary>
        /// <param name="value">The string to convert to base64 encode case.</param>
        /// <returns>The specified text converted to base64 encode case.</returns>
        public static string ToBase64EncodeCase(this string value)
        {
            return TextCase.Convert(value, Case.Base64EncodeCase);
        }
    }
}
