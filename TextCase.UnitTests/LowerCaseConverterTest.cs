using System;
using TextCase.Converters;
using TextCase.Extensions;
using Xunit;

namespace TextCase.UnitTests
{
    public class LowerCaseConverterTest
    {
        [Theory]
        [InlineData("Hello World", "hello world")]
        [InlineData("HELLO WORLD", "hello world")]
        [InlineData("ICH BIN GLÜCKLICH", "ich bin glücklich")]
        [InlineData("  Che Ore Sono? ", "  che ore sono? ")]
        public void Convert_WhenLowerCase_TextShouldBeLowerCase(string input, string output)
        {
            // Setup
            var service = new LowerCaseConverter();

            // Execute
            var convertedText = service.Convert(input);

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello World", "hello world")]
        [InlineData("HELLO WORLD", "hello world")]
        [InlineData("ICH BIN GLÜCKLICH", "ich bin glücklich")]
        [InlineData("  Che Ore Sono? ", "  che ore sono? ")]
        public void ToLowerCase_WhenLowerCase_TextShouldBeLowerCase(string input, string output)
        {
            // Execute
            var convertedText = input.ToLowerCase();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}