using System;
using TextCase.Converters;
using TextCase.Extensions;
using Xunit;

namespace TextCase.UnitTests
{
    public class InverseCaseConverterTest
    {
        [Theory]
        [InlineData("hello world", "hElLo WoRlD")]
        [InlineData("icH bIn glückLICH", "iCh BiN gLüCkLiCh")]
        [InlineData("  che ore sono? ", "  cHe OrE sOnO? ")]
        public void Convert_WhenCamelCase_TextShouldBeCamelCase(string input, string output)
        {
            // Setup
            var service = new InverseCaseConverter();

            // Execute
            var convertedText = service.Convert(input);

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello world", "hElLo WoRlD")]
        [InlineData("icH bIn glückLICH", "iCh BiN gLüCkLiCh")]
        [InlineData("  che ore sono? ", "  cHe OrE sOnO? ")]
        [InlineData("You talking to me?", "yOu TaLkInG tO mE?")]
        public void ToInverseCase_WhenCamelCase_TextShouldBeCamelCase(string input, string output)
        {
            // Execute
            var convertedText = input.ToInverseCase();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}