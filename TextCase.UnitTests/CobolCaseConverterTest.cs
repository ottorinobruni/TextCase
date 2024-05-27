using TextCase.Converters;
using TextCase.Extensions;
using Xunit;

namespace TextCase.UnitTests
{
    public class CobolCaseConverterTest
    {
        [Theory]
        [InlineData("hello world", "HELLO-WORLD")]
        [InlineData("icH bIn glückLICH", "ICH-BIN-GLÜCKLICH")]
        [InlineData("Hello World!", "HELLO-WORLD")]
        [InlineData("123 test", "123-TEST")]
        [InlineData("test with multiple   spaces", "TEST-WITH-MULTIPLE-SPACES")]
        [InlineData("test_with_underscore", "TEST-WITH-UNDERSCORE")]
        [InlineData("test-with-dash", "TEST-WITH-DASH")]
        [InlineData("test.with.period", "TEST-WITH-PERIOD")]
        [InlineData("test/with/slash", "TEST-WITH-SLASH")]
        [InlineData("test\\with\\backslash", "TEST-WITH-BACKSLASH")]
        public void Convert_WhenConstantCase_TextShouldBeConstantCase(string input, string expected)
        {
            // Setup
            var service = new CobolCaseConverter();

            // Execute
            var actual = service.Convert(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello world", "HELLO-WORLD")]
        [InlineData("icH bIn glückLICH", "ICH-BIN-GLÜCKLICH")]
        [InlineData("Hello World!", "HELLO-WORLD")]
        [InlineData("123 test", "123-TEST")]
        [InlineData("test with multiple   spaces", "TEST-WITH-MULTIPLE-SPACES")]
        [InlineData("test_with_underscore", "TEST-WITH-UNDERSCORE")]
        [InlineData("test-with-dash", "TEST-WITH-DASH")]
        [InlineData("test.with.period", "TEST-WITH-PERIOD")]
        [InlineData("test/with/slash", "TEST-WITH-SLASH")]
        [InlineData("test\\with\\backslash", "TEST-WITH-BACKSLASH")]
        public void ToCobolCase_WhenCobolCase_TextShouldBeCobolCase(string input, string output)
        {
            // Execute
            var convertedText = input.ToCobolCase();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}