using System;
using Xunit;

namespace Caesar_Cipher.Tests
{
    public class CaesarCipherTests
    {
        [Theory]
        [InlineData("middle-Outz", 2, "okffng-Qwvb")]
        [InlineData("Always-Look-on-the-Bright-Side-of-Life", 5, "Fqbfdx-Qttp-ts-ymj-Gwnlmy-Xnij-tk-Qnkj")]
        public void EncodeTest(string sentence, int offset, string expected)
        {
            string actual = CaesarCipher.Encode(sentence, offset);

            Assert.Equal(expected, actual);
        }
    }
}