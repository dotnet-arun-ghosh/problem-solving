using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_Solving;

namespace Problem_Solving_Tests
{
    [TestClass]
    public class NonRepeatingFirstCharcterTests
    {
        [TestMethod]
        public void GetNonRepeatingFirstCharcterMethodShouldReturnEmptyCharWhenStringIsEmpty()
        {
            var response = NonRepeatingFirstCharcter.GetNonRepeatingFirstCharacter(string.Empty);
            Assert.AreEqual(default(char), response);
        }

        [TestMethod]
        public void GetNonRepeatingFirstCharcterMethodShouldReturnEmptyCharWhenStringIsNull()
        {
            var response = NonRepeatingFirstCharcter.GetNonRepeatingFirstCharacter(null);
            Assert.AreEqual(default(char), response);
        }

        [TestMethod]
        public void GetNonRepeatingFirstCharcterMethodShouldReturnEmptyCharWhenStringIsWhiteSpace()
        {
            var response = NonRepeatingFirstCharcter.GetNonRepeatingFirstCharacter(" ");
            Assert.AreEqual(default(char), response);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void GetNonRepeatingFirstCharcterMethodShouldThrowFormatExcpetionWhenGivingStringContainsOneUpperCaseCharacter()
        {
            var response = NonRepeatingFirstCharcter.GetNonRepeatingFirstCharacter("Ihaveuppercaseletter");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void GetNonRepeatingFirstCharcterMethodShouldThrowFormatExcpetionWhenGivingStringContainsNumericCharacters()
        {
            var response = NonRepeatingFirstCharcter.GetNonRepeatingFirstCharacter("1havenumericcharacters");
        }

        [TestMethod]
        public void GetNonRepeatingFirstCharcterMethodShouldReturnDefaultCharacterWhenThestringGivenIsNotHavingNonRepeatingCharacter()
        {
            var response = NonRepeatingFirstCharcter.GetNonRepeatingFirstCharacter("daabcabcd");
            Assert.AreEqual(default(char), response);
        }

        [TestMethod]
        public void GetNonRepeatingFirstCharcterMethodShouldReturnFirstNonRepeatingCharcterEvenIfThereIsMultipleNonRepeatingCharacter()
        {
            var response = NonRepeatingFirstCharcter.GetNonRepeatingFirstCharacter("abcaadbaxyz");
            Assert.AreEqual('c', response);
        }

        [TestMethod]
        public void GetNonRepeatingFirstCharcterMethodShouldReturnFirstNonRepeatingCharcter()
        {
            var response = NonRepeatingFirstCharcter.GetNonRepeatingFirstCharacter("aabbbx");
            Assert.AreEqual('x', response);
        }
    }
}
