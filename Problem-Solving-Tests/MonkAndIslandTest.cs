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
    public class MonkAndIslandTest
    {
        [TestMethod]
        public void GetShortestPathMethodShouldReturnTwoWhenBelowGivenArrayIsPassed()
        {          

            var connection = new int[4][];

            connection[0] = new int[] { 1, 2 };
            connection[1] = new int[] { 2, 3 };
            connection[2] = new int[] { 3, 4 };
            connection[3] = new int[] { 4, 2 };


            var result = MonkAndIsland.GetShortestPath(4, connection);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GetShortestPathMethodShouldReturnTwoWhenBelowGivenArrayIsPassed1()
        {

            var connection = new int[2][];

            connection[0] = new int[] { 1, 2 };
            connection[1] = new int[] { 2, 3 };


            var result = MonkAndIsland.GetShortestPath(3, connection);
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void GetShortestPathMethodShouldReturnFourWhenBelowGivenArrayIsPassed1()
        {

            var connection = new int[10][];

            connection[0] = new int[] { 1, 3 };
            connection[1] = new int[] { 1, 2 };
            connection[2] = new int[] { 3, 7 };
            connection[3] = new int[] { 5, 3 };
            connection[4] = new int[] { 6, 8 };
            connection[5] = new int[] { 6, 2 };
            connection[6] = new int[] { 4, 8};
            connection[7] = new int[] { 7, 4 };
            connection[8] = new int[] { 8, 5};
            connection[9] = new int[] { 5, 2 };


            var result = MonkAndIsland.GetShortestPath(8, connection);

            Assert.AreEqual(3, result);

        }
    }
}
