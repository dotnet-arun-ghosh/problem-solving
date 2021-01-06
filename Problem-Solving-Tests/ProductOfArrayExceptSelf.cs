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
    public class ProductOfArrayExceptSelfTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            var response =ProductOfArrayExceptSelf.ProductExceptSelf1(new int[] { 1, 2, 3, 4 });

            Assert.AreEqual(1, response);
        }
    }
}
