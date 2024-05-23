using System;
using TextCase.Converters;
using TextCase.Extensions;
using Xunit;

namespace TextCase.UnitTests
{
    public class PascalCaseConverterTest
    {
        [Theory]
        [InlineData("hello world", "HelloWorld")]
        [InlineData("icH bIn glückLICH", "IchBinGlücklich")]
        [InlineData("  che ore sono? ", "CheOreSono?")]
        [InlineData("iPhone", "Iphone")]
        [InlineData("  Hello  World  ", "HelloWorld")]
        [InlineData("hello\tworld", "HelloWorld")]
        [InlineData("Today i am happy\nToday i am happy", "TodayIAmHappy\nTodayIAmHappy")]
        public void Convert_WhenPascalCase_TextShouldBePascalCase(string input, string output)
        {
            // Setup
            var service = new PascalCaseConverter();

            // Execute
            var convertedText = service.Convert(input);

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello world", "HelloWorld")]
        [InlineData("icH bIn glückLICH", "IchBinGlücklich")]
        [InlineData("  che ore sono? ", "CheOreSono?")]
        [InlineData("iPhone", "Iphone")]
        [InlineData("  Hello  World  ", "HelloWorld")]
        [InlineData("hello\tworld", "HelloWorld")]
        [InlineData("Today i am happy\nToday i am happy", "TodayIAmHappy\nTodayIAmHappy")]
        public void ToPascalCase_WhenUpperCase_TextShouldBePascalCase(string input, string output)
        {
            // Execute
            var convertedText = input.ToPascalCase();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}