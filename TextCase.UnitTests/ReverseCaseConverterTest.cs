using System;
using TextCase.Converters;
using TextCase.Extensions;
using Xunit;

namespace TextCase.UnitTests
{
    public class ReverseCaseConverterTest
    {
        [Theory]
        [InlineData("Hello World", "dlroW olleH")]
        [InlineData("ich bin glücklich", "hcilkcülg nib hci")]
        [InlineData("  che ore sono? ", " ?onos ero ehc  ")]
        public void Convert_WhenUpperCase_TextShouldBeUpperCase(string input, string output)
        {
            // Setup
            var service = new ReverseCaseConverter();

            // Execute
            var convertedText = service.Convert(input);

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello World", "dlroW olleH")]
        [InlineData("ich bin glücklich", "hcilkcülg nib hci")]
        [InlineData("  che ore sono? ", " ?onos ero ehc  ")]
        public void ToReverseCase_WhenUpperCase_TextShouldBeUpperCase(string input, string output)
        {
            // Execute
            var convertedText = input.ToReverseCase();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}