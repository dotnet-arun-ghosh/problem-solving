using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_Solving;

namespace Problem_Solving_Tests
{
    [TestClass]
    public class TopKFrequentlyMentionedKeywordTests
    {
        [TestMethod]
        public void GetFrequentlyMentionedKeywordMethodShouldReturnAnacellAndBetacellularInSequenceWhenAnacellAndBetacellularIsMostlyMentionedInReviewAndAnacellIsMoreThanBetacellular()
        {
            int k = 2;
            string[] keywords = new string[] { "anacell", "cetracular", "betacellular" };
            string[] reviews = new string[]{
              "Anacell provides the best services in the city",
              "betacellular has awesome services",
              "Best services provided by anacell, everyone should use anacell"
            };
            var responseArray = TopKFrequentlyMentionedKeyword.GetFrequentlyMentionedKeyword(k, keywords, reviews);

            Assert.AreEqual("anacell", responseArray[0]);
            Assert.AreEqual("betacellular", responseArray[1]);
            Assert.AreEqual(k, responseArray.Length);
        }

        [TestMethod]
        public void GetFrequentlyMentionedKeywordMethodShouldReturnBetacellularAndAnacellInSequenceWhenBetacellularAndAnacellIsMostlyMentionedInReviewBetacellularIsMoreThanAnacell()
        {
            int k = 2;
            string[] keywords = new string[] { "anacell", "betacellular", "cetracular", "deltacellular", "eurocell" };
            string[] reviews = new string[]{
              "I love anacell Best services; Best services provided by anacell",
              "betacellular has great services",
              "deltacellular provides much better services than betacellular",
              "cetracular is worse than anacell",
              "Betacellular is better than deltacellular."
            };
            var responseArray = TopKFrequentlyMentionedKeyword.GetFrequentlyMentionedKeyword(k, keywords, reviews);

            Assert.AreEqual("anacell", responseArray[1]);
            Assert.AreEqual("betacellular", responseArray[0]);
            Assert.AreEqual(k, responseArray.Length);
        }

        [TestMethod]
        public void GetFrequentlyMentionedKeywordMethodShouldReturnAnacellAndBetacellularInSequenceWhenAnacellAndBetacellularIsMostlyMentionedInReviewAndAnacellAndBetacellularSameNumberOfTimeAsAnacellComesFirstInAlphabet()
        {
            int k = 2;
            string[] keywords = new string[] { "anacell", "betacellular", "cetracular", "deltacellular", "eurocell" };
            string[] reviews = new string[]{
              "I love anacell Best services; Best services provided by anacell",
              "betacellular has great services",
              "deltacellular provides much better services than betacellular",
              "cetracular anacell is worse than anacell",
              "Betacellular is better than deltacellular. anacell"
            };
            var responseArray = TopKFrequentlyMentionedKeyword.GetFrequentlyMentionedKeyword(k, keywords, reviews);

            Assert.AreEqual("anacell", responseArray[0]);
            Assert.AreEqual("betacellular", responseArray[1]);
            Assert.AreEqual(k, responseArray.Length);
        }
    }
}
