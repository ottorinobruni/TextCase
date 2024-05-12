using System;
using TextCase.Converters;
using TextCase.Extensions;
using Xunit;

namespace TextCase.UnitTests
{
    public class AlternateCaseConverterTest
    {
        [Theory]
        [InlineData("hello world", "HeLlO wOrLd")]
        [InlineData("icH bIn glückLICH", "IcH bIn GlÜcKlIcH")]
        [InlineData("  che ore sono? ", "  ChE oRe SoNo? ")]
        public void Convert_WhenCamelCase_TextShouldBeCamelCase(string input, string output)
        {
            // Setup
            var service = new AlternateCaseConverter();

            // Execute
            var convertedText = service.Convert(input);

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello world", "HeLlO wOrLd")]
        [InlineData("icH bIn glückLICH", "IcH bIn GlÜcKlIcH")]
        [InlineData("  che ore sono? ", "  ChE oRe SoNo? ")]
        public void ToAlternateCase_WhenCamelCase_TextShouldBeCamelCase(string input, string output)
        {
            // Execute
            var convertedText = input.ToAlternateCase();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}