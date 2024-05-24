using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextCase.Converters;
using TextCase.Extensions;
using Xunit;

namespace TextCase.UnitTests
{
    public class Base64EncodeCaseConverterTest
    {
        [Theory]
        [InlineData("Hello World", "SGVsbG8gV29ybGQ=")]
        [InlineData("HELLO WORLD", "SEVMTE8gV09STEQ=")]
        [InlineData("ICH BIN GLÜCKLICH", "SUNIIEJJTiBHTMOcQ0tMSUNI")]
        [InlineData("  Che Ore Sono? ", "ICBDaGUgT3JlIFNvbm8/IA==")]
        public void ToBase64EncodeCase_WhenValidInput_ShouldReturnBase64EncodedString(string input, string expected)
        {
            // Setup
            var service = new Base64EncodeCaseConverter();

            // Execute
            var actual = service.Convert(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello World", "SGVsbG8gV29ybGQ=")]
        [InlineData("HELLO WORLD", "SEVMTE8gV09STEQ=")]
        [InlineData("ICH BIN GLÜCKLICH", "SUNIIEJJTiBHTMOcQ0tMSUNI")]
        [InlineData("  Che Ore Sono? ", "ICBDaGUgT3JlIFNvbm8/IA==")]
        public void ToBase64EncodeCase_WhenBase64EncodeCase_TextShouldBeBase64EncodeCase(string input, string output)
        {
            // Execute
            var convertedText = input.ToBase64EncodeCase();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}
