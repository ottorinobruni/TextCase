using TextCase.Converters;
using TextCase.Extensions;
using Xunit;

namespace TextCase.UnitTests
{
    public class Rot13CaseConverterTest
    {
        [Theory]
        [InlineData("Hello World", "Uryyb Jbeyq")]
        [InlineData("hello world", "uryyb jbeyq")]
        [InlineData("HELLO WORLD", "URYYB JBEYQ")]
        [InlineData("ABC", "NOP")]
        [InlineData("abc", "nop")]
        [InlineData("Hello 123!", "Uryyb 123!")]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData("\t", "")]
        public void Convert_WhenRot13Case_TextShouldBeRot13Case(string input, string output)
        {
            // Setup
            var service = new Rot13CaseConverter();

            // Execute
            var convertedText = service.Convert(input);

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello World", "Uryyb Jbeyq")]
        [InlineData("Uryyb Jbeyq", "Hello World")]
        [InlineData("", "")]
        public void ToRot13Case_WhenRot13Case_TextShouldBeRot13Case(string input, string output)
        {
            // Execute
            var convertedText = input.ToRot13Case();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello World")]
        [InlineData("The quick brown fox")]
        [InlineData("ABC xyz 123")]
        public void ToRot13Case_AppliedTwice_ShouldReturnOriginal(string input)
        {
            // ROT13 is self-inverse
            var result = input.ToRot13Case().ToRot13Case();
            Assert.Equal(input, result);
        }
    }
}
