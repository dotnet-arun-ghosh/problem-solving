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
    public class BuyAndSellStockTest
    {
        [TestMethod]
        public void BuySellStock()
        {
            var response = BuyAndSellStock.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });

            Assert.AreEqual(5, response);
        }

        [TestMethod]
        public void BuySellStock1()
        {
            var response = BuyAndSellStock.MaxProfit(new int[] { 7, 6, 4, 3, 1 });

            Assert.AreEqual(0, response);
        }

        [TestMethod]
        public void BuySellStock8()
        {
            var response = BuyAndSellStock.MaxProfit(new int[] { 7, 6, 8, 3, 1 });

            Assert.AreEqual(2, response);
        }

        [TestMethod]
        public void BuySellStock9()
        {
            var response = BuyAndSellStock.MaxProfit(new int[] { 9, 8, 7, 3, 1 });

            Assert.AreEqual(0, response);
        }

        [TestMethod]
        public void BuySellStock10()
        {
            var response = BuyAndSellStock.MaxProfit(new int[] { 9, 8, 7, 10, 1 });

            Assert.AreEqual(3, response);
        }

        [TestMethod]
        public void BuySellStock11()
        {
            var response = BuyAndSellStock.MaxProfit(new int[] { 9, 8, 9, 7, 1 });

            Assert.AreEqual(1, response);
        }

        [TestMethod]
        public void BuySellStock12()
        {
            var response = BuyAndSellStock.MaxProfit(new int[] { 3, 2, 6, 5, 0, 3 });

            Assert.AreEqual(4, response);
        }
        [TestMethod]
        public void BuySellStock13()
        {
            var response = BuyAndSellStock.MaxProfit(new int[] { 2, 1, 2, 1, 0, 0, 1 });

            Assert.AreEqual(1, response);
        }

        [TestMethod]
        public void BuySellStock14()
        {
            var response = BuyAndSellStock.MaxProfit(new int[] { 2, 7, 1, 4 });

            Assert.AreEqual(5, response);
        }

        [TestMethod]
        public void BuySellStock15()
        {
            var response = BuyAndSellStock.MaxProfit(new int[] { 5, 32, 4, 29, 1, 39, 40 });

            Assert.AreEqual(39, response);
        }


        [TestMethod]
        public void BuySellStock2()
        {
            var response = BuyAndSellStock.MaxProfit(new int[] { 7 });

            Assert.AreEqual(0, response);
        }

        [TestMethod]
        public void BuySellStock3()
        {
            var response = BuyAndSellStock.MaxProfit(new int[] { 7, 2 });

            Assert.AreEqual(0, response);
        }

        [TestMethod]
        public void BuySellStock4()
        {
            var response = BuyAndSellStock.MaxProfit(new int[] { });

            Assert.AreEqual(0, response);
        }

        [TestMethod]
        public void BuySellStock5()
        {
            var response = BuyAndSellStock.MaxProfit(new int[] { });

            Assert.AreEqual(0, response);
        }
    }
}
