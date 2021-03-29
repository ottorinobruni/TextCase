using System;
using TextCase.Converters;
using Xunit;

namespace TextCase.UnitTests
{
    public class KebabCaseConverterTest
    {
        [Theory]
        [InlineData("hello world", "hello-world")]
        [InlineData("icH bIn glückLICH", "ich-bin-glücklich")]
        [InlineData(" che ore sono? ", "-che-ore-sono?-")]
        public void Convert_WhenKebabCase_TextShouldBeKebabCase(string input, string output)
        {
            // Setup
            var service = new KebabCaseConverter();

            // Execute
            var convertedText = service.Convert(input);

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}