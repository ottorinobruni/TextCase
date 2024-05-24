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
    public class Base64DecodeCaseConverterTest
    {
        [Theory]
        [InlineData("SGVsbG8gV29ybGQ=", "Hello World")]
        [InlineData("SEVMTE8gV09STEQ=", "HELLO WORLD")]
        [InlineData("SUNIIEJJTiBHTMOcQ0tMSUNI", "ICH BIN GLÜCKLICH")]
        [InlineData("ICBDaGUgT3JlIFNvbm8/IA==", "  Che Ore Sono? ")]
        public void ToBase64DecodeCase_WhenValidInput_ShouldReturnDecodedString(string input, string expected)
        {
            // Setup
            var service = new Base64DecodeCaseConverter();

            // Execute
            var actual = service.Convert(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("SGVsbG8gV29ybGQ=", "Hello World")]
        [InlineData("SEVMTE8gV09STEQ=", "HELLO WORLD")]
        [InlineData("SUNIIEJJTiBHTMOcQ0tMSUNI", "ICH BIN GLÜCKLICH")]
        [InlineData("ICBDaGUgT3JlIFNvbm8/IA==", "  Che Ore Sono? ")]
        public void ToBase64DecodeCase_WhenBase64DecodeCase_TextShouldBeBase64DecodeCase(string input, string output)
        {
            // Execute
            var convertedText = input.ToBase64DecodeCase();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}
