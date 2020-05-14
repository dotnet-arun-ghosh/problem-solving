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
    public class LongestPalindromicSubStringTest
    {
        [TestMethod]
        public void GetLongestPalindromicSubstringShouldReturnMalayalamWhenTheStringMalayalamIsPassed()
        {
            var result = LongestPalindromicSubString.GetLongestPalindromicSubstring("malayalam");

            Assert.AreEqual("malayalam", result);
        }

        [TestMethod]
        public void GetLongestPalindromicSubstringShouldReturnabbaWhenTheStringtxabbayyIsPassed()
        {
            var result = LongestPalindromicSubString.GetLongestPalindromicSubstring("txabbayy");

            Assert.AreEqual("abba", result);
        }

        [TestMethod]
        public void GetLongestPalindromicSubstringShouldReturnxalaxWhenTheStringmxyxalaxkyIsPassed()
        {
            var result = LongestPalindromicSubString.GetLongestPalindromicSubstring("mxyxalaxky");

            Assert.AreEqual("xalax", result);
        }

        [TestMethod]
        public void GetLongestPalindromicSubstringShouldReturnabaabaWhenTheStringabaabaIsPassed()
        {
            var result = LongestPalindromicSubString.GetLongestPalindromicSubstring("abaaba");

            Assert.AreEqual("abaaba", result);
        }

        [TestMethod]
        public void GetLongestPalindromicSubstringShouldReturnalaWhenTheStringxycalazIsPassed()
        {
            var result = LongestPalindromicSubString.GetLongestPalindromicSubstring("xycalaz");

            Assert.AreEqual("ala", result);
        }

        [TestMethod]
        public void GetLongestPalindromicSubstringShouldReturnalaWhenTheStringxyalazIsPassed()
        {
            var result = LongestPalindromicSubString.GetLongestPalindromicSubstring("xyalaz");

            Assert.AreEqual("ala", result);
        }

        [TestMethod]
        public void GetLongestPalindromicSubstringShouldReturnmalayalamWhenTheStringmalayalamisablaalbIsPassed1()
        {
            var result = LongestPalindromicSubString.GetLongestPalindromicSubstring("malayalamisablaalb");

            Assert.AreEqual("malayalam", result);
        }


        [TestMethod]
        public void GetLongestPalindromicSubstringShouldReturnbabaxyyxababWhenTheStringmalayalamisablaalbIsPassed()
        {
            var result = LongestPalindromicSubString.GetLongestPalindromicSubstring("racecarisbabaxyyxabab");

            Assert.AreEqual("babaxyyxabab", result);
        }
    }
}
