using System;
using TextCase.Converters;

namespace TextCase
{
    public static class TextCaseFactory
    {
        public static ICaseConverter GetCaseConverter(Case textCase)
        {
            switch (textCase)
            {
                case Case.UpperCase:
                    return new UpperCaseConverter();
                case Case.LowerCase:
                    return new LowerCaseConverter();
                case Case.TitleCase:
                    return new TitleCaseConverter();
                case Case.CapitaliseCase:
                    return new CapitaliseCaseConverter();
                case Case.CapitaliseWordsCase:
                    return new CapitaliseWordsCaseConverter();
                case Case.ReverseCase:
                    return new ReverseCaseConverter();
                case Case.AlternateCase:
                    return new AlternateCaseConverter();
                case Case.CamelCase:
                    return new CamelCaseConverter();
                case Case.PascalCase:
                    return new PascalCaseConverter();
                case Case.KebabCase:
                    return new KebabCaseConverter();
                case Case.SnackCase:
                    return new SnackCaseConverter();
                case Case.HashtagCase:
                    return new HashtagCaseConverter();
                default:
                    throw new ArgumentException("No valid TextCase");
            }
        }
    }
}
