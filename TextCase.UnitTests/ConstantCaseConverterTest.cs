using TextCase.Converters;
using TextCase.Extensions;
using Xunit;

namespace TextCase.UnitTests
{
    public class ConstantCaseConverterTest
    {
        [Theory]
        [InlineData("hello world", "HELLO_WORLD")]
        [InlineData("icH bIn glückLICH", "ICH_BIN_GLÜCKLICH")]
        [InlineData("Hello World!", "HELLO_WORLD")]
        [InlineData("123 test", "123_TEST")]
        [InlineData("test with multiple   spaces", "TEST_WITH_MULTIPLE_SPACES")]
        [InlineData("test_with_underscore", "TEST_WITH_UNDERSCORE")]
        [InlineData("test-with-dash", "TEST_WITH_DASH")]
        [InlineData("test.with.period", "TEST_WITH_PERIOD")]
        [InlineData("test/with/slash", "TEST_WITH_SLASH")]
        [InlineData("test\\with\\backslash", "TEST_WITH_BACKSLASH")]
        public void Convert_WhenConstantCase_TextShouldBeConstantCase(string input, string expected)
        {
            // Setup
            var service = new ConstantCaseConverter();

            // Execute
            var actual = service.Convert(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello world", "HELLO_WORLD")]
        [InlineData("icH bIn glückLICH", "ICH_BIN_GLÜCKLICH")]
        [InlineData("Hello World!", "HELLO_WORLD")]
        [InlineData("123 test", "123_TEST")]
        [InlineData("test with multiple   spaces", "TEST_WITH_MULTIPLE_SPACES")]
        [InlineData("test_with_underscore", "TEST_WITH_UNDERSCORE")]
        [InlineData("test-with-dash", "TEST_WITH_DASH")]
        [InlineData("test.with.period", "TEST_WITH_PERIOD")]
        [InlineData("test/with/slash", "TEST_WITH_SLASH")]
        [InlineData("test\\with\\backslash", "TEST_WITH_BACKSLASH")]
        public void ToConstantCase_WhenConstantCase_TextShouldBeConstantCase(string input, string output)
        {
            // Execute
            var convertedText = input.ToConstantCase();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}