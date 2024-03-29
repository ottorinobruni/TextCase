using System;
using TextCase.Converters;
using TextCase.Extensions;
using Xunit;

namespace TextCase.UnitTests
{
    public class UpperCaseConverterTest
    {
        [Theory]
        [InlineData("Hello World", "HELLO WORLD")]
        [InlineData("ich bin glücklich", "ICH BIN GLÜCKLICH")]
        [InlineData("  che ore sono? ", "  CHE ORE SONO? ")]
        public void Convert_WhenUpperCase_TextShouldBeUpperCase(string input, string output)
        {
            // Setup
            var service = new UpperCaseConverter();

            // Execute
            var convertedText = service.Convert(input);

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello World", "HELLO WORLD")]
        [InlineData("ich bin glücklich", "ICH BIN GLÜCKLICH")]
        [InlineData("  che ore sono? ", "  CHE ORE SONO? ")]
        public void ToUpperCase_WhenUpperCase_TextShouldBeUpperCase(string input, string output)
        {
            var convertedText = input.ToUpperCase();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}