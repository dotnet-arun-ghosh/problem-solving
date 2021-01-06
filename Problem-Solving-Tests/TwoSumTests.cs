using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Problem_Solving;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Tests
{
    [TestClass]
    public class TwoSumTests
    {
        [TestMethod]
        public void getTwoSome()
        {
            var response = TwoSum.TwoSumValueOn(new int[] {-1, -2, -3, -4, -5}, -8);

            Assert.IsNotNull(response);
        }
    }
}
