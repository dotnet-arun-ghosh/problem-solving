using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_Solving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Tests
{
    [TestClass]
    public class NonRepeatingLongestSubstringTest
    {
        [TestMethod]
        public void GetNonRepeatingLongestSubstringShouldReturnabcWhenabcabcbbIsPassedInRequest()
        {
            var response = NonRepeatingLongestSubstring.GetNonRepeatingLongestSubstring("abcabcbb");

            Assert.AreEqual("abc", response);
        }

        [TestMethod]
        public void GetNonRepeatingLongestSubstringShouldReturnbWhenbbbbIsPassedInRequest()
        {
            var response = NonRepeatingLongestSubstring.GetNonRepeatingLongestSubstring("bbbb");

            Assert.AreEqual("b", response);
        }

        [TestMethod]
        public void GetNonRepeatingLongestSubstringShouldReturnwkeWhenpwwkewIsPassedInRequest()
        {
            var response = NonRepeatingLongestSubstring.GetNonRepeatingLongestSubstring("pwwkew");

            Assert.AreEqual("wke", response);
        }

        [TestMethod]
        public void GetNonRepeatingLongestSubstringShouldReturnabchelotmzxWhenabcxdxabcabchelotmzxIsPassedInRequest()
        {
            var response = NonRepeatingLongestSubstring.GetNonRepeatingLongestSubstring("abcxdxabcabchelotmzx");

            Assert.AreEqual("abchelotmzx", response);
        }

        [TestMethod]
        public void GetNonRepeatingLongestSubstringShouldReturnabcxWhenabcxdabcIsPassedInRequest()
        {
            var response = NonRepeatingLongestSubstring.GetNonRepeatingLongestSubstring("abcxdabc");

            Assert.AreEqual("abcxd", response);
        }

        [TestMethod]
        public void GetNonRepeatingLongestSubstringShouldReturnhowareuWhenhowareuIsPassedInRequest()
        {
            var response = NonRepeatingLongestSubstring.GetNonRepeatingLongestSubstring("howareu");

            Assert.AreEqual("howareu", response);
        }

        [TestMethod]
        public void GetNonRepeatingLongestSubstringShouldReturnxWhenxIsPassedInRequest()
        {
            var response = NonRepeatingLongestSubstring.GetNonRepeatingLongestSubstring("x");

            Assert.AreEqual("x", response);
        }

        [TestMethod]
        public void GetNonRepeatingLongestSubstringShouldReturnzyzuWhenabcxyzuabcIsPassedInRequest()
        {
            var response = NonRepeatingLongestSubstring.GetNonRepeatingLongestSubstring("abcayzuabc");

            Assert.AreEqual("x", response);
        }
    }
}
