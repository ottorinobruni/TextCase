using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextCase.Converters;
using TextCase.Extensions;
using Xunit;

namespace TextCase.UnitTests
{
    public class TrainCaseConverterTest
    {
        [Theory]
        [InlineData("hello world", "Hello-World")]
        [InlineData("icH bIn glückLICH", "Ich-Bin-Glücklich")]
        [InlineData("indent_style = space, 2-\nindent_size = 2", "Indent-Style-Space-2\nIndent-Size-2")]
        [InlineData("Hello World!", "Hello-World")]
        [InlineData("123 test", "123-Test")]
        [InlineData("test with multiple   spaces", "Test-With-Multiple-Spaces")]
        [InlineData("test_with_underscore", "Test-With-Underscore")]
        [InlineData("test-with-dash", "Test-With-Dash")]
        [InlineData("test.with.period", "Test-With-Period")]
        [InlineData("test/with/slash", "Test-With-Slash")]
        [InlineData("test\\with\\backslash", "Test-With-Backslash")]
        public void Convert_WhenTrainCase_TextShouldBeTrainCase(string input, string expected)
        {
            // Setup
            var service = new TrainCaseConverter();

            // Execute
            var actual = service.Convert(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello world", "Hello-World")]
        [InlineData("icH bIn glückLICH", "Ich-Bin-Glücklich")]
        [InlineData("indent_style = space, 2-\nindent_size = 2", "Indent-Style-Space-2\nIndent-Size-2")]
        [InlineData("Hello World!", "Hello-World")]
        [InlineData("123 test", "123-Test")]
        [InlineData("test with multiple   spaces", "Test-With-Multiple-Spaces")]
        [InlineData("test_with_underscore", "Test-With-Underscore")]
        [InlineData("test-with-dash", "Test-With-Dash")]
        [InlineData("test.with.period", "Test-With-Period")]
        [InlineData("test/with/slash", "Test-With-Slash")]
        [InlineData("test\\with\\backslash", "Test-With-Backslash")]
        public void ToTrainCase_WhenTrainCase_TextShouldBeTrainCase(string input, string output)
        {
            // Execute
            var convertedText = input.ToTrainCase();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}
