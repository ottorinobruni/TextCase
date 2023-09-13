using System;
using TextCase.Converters;
using TextCase.Extensions;
using Xunit;

namespace TextCase.UnitTests
{
    public class SnackCaseConverterTest
    {
        [Theory]
        [InlineData("hello world", "hello_world")]
        [InlineData("icH bIn glückLICH", "ich_bin_glücklich")]
        [InlineData(" che ore sono? ", "_che_ore_sono?_")]
        public void Convert_WhenSnackCase_TextShouldBeSnackCase(string input, string output)
        {
            // Setup
            var service = new SnackCaseConverter();

            // Execute
            var convertedText = service.Convert(input);

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello world", "hello_world")]
        [InlineData("icH bIn glückLICH", "ich_bin_glücklich")]
        [InlineData(" che ore sono? ", "_che_ore_sono?_")]
        public void ToSnackCase_WhenSnackCase_TextShouldBeSnackCase(string input, string output)
        {
            // Execute
            var convertedText = input.ToSnackCase();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}