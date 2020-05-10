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
    public class SearchSuggestionsTest
    {
        [TestMethod]
        public void SuggestedProductsMethodShouldReturnExpectedOutBelowIfGivenParameterIsMouse()
        {
            var products = new string[] { "mobile", "mouse", "moneypot", "monitor", "mousepad" };
            var searchWord = "mouse";

            var response = SearchSuggestions.SuggestedProducts(products, searchWord);

            Assert.AreEqual(5, response.Count);
            Assert.AreEqual("mobile", response[0][0]);
            Assert.AreEqual("moneypot", response[0][1]);
            Assert.AreEqual("monitor", response[0][2]);
            Assert.AreEqual("mobile", response[1][0]);
            Assert.AreEqual("moneypot", response[1][1]);
            Assert.AreEqual("monitor", response[1][2]);
            Assert.AreEqual("mouse", response[2][0]);
            Assert.AreEqual("mousepad", response[2][1]);
            Assert.AreEqual("mouse", response[3][0]);
            Assert.AreEqual("mousepad", response[3][1]);
            Assert.AreEqual("mouse", response[4][0]);
            Assert.AreEqual("mousepad", response[4][1]);
        }

        [TestMethod]
        public void SuggestedProductsMethodShouldReturnExpectedOutBelowIfGivenParameterIsHavana()
        {
            var products = new string[] { "havana" };
            var searchWord = "havana";

            var response = SearchSuggestions.SuggestedProducts(products, searchWord);

            Assert.AreEqual(6, response.Count);
            Assert.AreEqual("havana", response[0][0]);
            Assert.AreEqual("havana", response[1][0]);
            Assert.AreEqual("havana", response[2][0]);
            Assert.AreEqual("havana", response[3][0]);
            Assert.AreEqual("havana", response[4][0]);
            Assert.AreEqual("havana", response[5][0]);
        }

        [TestMethod]
        public void SuggestedProductsMethodShouldReturnExpectedOutBelowIfGivenParameterIsBags()
        {
            var products = new string[] { "bags", "baggage", "banner", "box", "cloths" };
            var searchWord = "bags";

            var response = SearchSuggestions.SuggestedProducts(products, searchWord);

            Assert.AreEqual(4, response.Count);
            Assert.AreEqual("baggage", response[0][0]);
            Assert.AreEqual("bags", response[0][1]);
            Assert.AreEqual("banner", response[0][2]);
            Assert.AreEqual("baggage", response[1][0]);
            Assert.AreEqual("bags", response[1][1]);
            Assert.AreEqual("banner", response[1][2]);
            Assert.AreEqual("baggage", response[2][0]);
            Assert.AreEqual("bags", response[2][1]);
            Assert.AreEqual("bags", response[3][0]);
        }

        [TestMethod]
        public void SuggestedProductsMethodShouldReturnExpectedOutBelowIfGivenParameterIsTatiana()
        {
            var products = new string[] { "havana" };
            var searchWord = "tatiana";

            var response = SearchSuggestions.SuggestedProducts(products, searchWord);

            Assert.AreEqual(7, response.Count);
            Assert.AreEqual(0, response[0].Count);
            Assert.AreEqual(0, response[1].Count);
            Assert.AreEqual(0, response[2].Count);
            Assert.AreEqual(0, response[3].Count);
            Assert.AreEqual(0, response[4].Count);
            Assert.AreEqual(0, response[5].Count);
            Assert.AreEqual(0, response[6].Count);
        }
    }
}
