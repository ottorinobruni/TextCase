using System;
using TextCase.Converters;

namespace TextCase
{
    internal static class TextCaseFactory
    {
        internal static ICaseConverter GetCaseConverter(Case textCase)
        {
            return textCase switch
            {
                Case.UpperCase => new UpperCaseConverter(),
                Case.LowerCase => new LowerCaseConverter(),
                Case.TitleCase => new TitleCaseConverter(),
                Case.CapitaliseCase => new CapitaliseCaseConverter(),
                Case.CapitaliseWordsCase => new CapitaliseWordsCaseConverter(),
                Case.ReverseCase => new ReverseCaseConverter(),
                Case.AlternateCase => new AlternateCaseConverter(),
                Case.CamelCase => new CamelCaseConverter(),
                Case.PascalCase => new PascalCaseConverter(),
                Case.KebabCase => new KebabCaseConverter(),
                Case.SnackCase => new SnackCaseConverter(),
                Case.HashtagCase => new HashtagCaseConverter(),
                _ => throw new ArgumentException("No valid TextCase"),
            };
        }
    }
}
