using TextCase.Converters;
using TextCase.Extensions;
using Xunit;

namespace TextCase.UnitTests
{
    public class DotCaseConverterTest
    {
        [Theory]
        [InlineData("hello world", "hello.world")]
        [InlineData("Hello World", "hello.world")]
        [InlineData("HELLO WORLD", "hello.world")]
        [InlineData("hello_world", "hello.world")]
        [InlineData("hello-world", "hello.world")]
        [InlineData("  Hello  World  ", "hello.world")]
        [InlineData("icH bIn glückLICH", "ich.bin.glücklich")]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData("\t", "")]
        [InlineData("\n", "")]
        public void Convert_WhenDotCase_TextShouldBeDotCase(string input, string output)
        {
            // Setup
            var service = new DotCaseConverter();

            // Execute
            var convertedText = service.Convert(input);

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello world", "hello.world")]
        [InlineData("Hello World", "hello.world")]
        [InlineData("HELLO WORLD", "hello.world")]
        [InlineData("", "")]
        public void ToDotCase_WhenDotCase_TextShouldBeDotCase(string input, string output)
        {
            // Execute
            var convertedText = input.ToDotCase();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}
