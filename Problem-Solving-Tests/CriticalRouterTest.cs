using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_Solving;

namespace Problem_Solving_Tests
{
    [TestClass]
    public class CriticalRouterTest
    {
        [TestMethod]
        public void CriticalConnectionsMethodShouldReturnOneAndThreeAsResponseWhenBelowConectionDetailsAreProvided()
        {
            var connection = new int[][]
           {
                new int[]{0,1},
                new int[]{1,2},
                new int[]{2,0},
                new int[]{1,3}
           };
            var response = CriticalRouter.CriticalConnections(4, connection);

            Assert.AreEqual(1, response.Count);
            Assert.AreEqual(1, response[0][0]);
            Assert.AreEqual(3, response[0][1]);
        }

        [TestMethod]
        public void CriticalConnectionsMethodShouldReturnOneAndSevenAsResponseWhenBelowConectionDetailsAreProvided()
        {

            var connection = new int[][]
            {
                new int[]{0,1},
                new int[]{0,2},
                new int[]{1,3},
                new int[]{2,3},
                new int[]{2,5},
                new int[]{5,6},
                new int[]{3,4},
            };
            var response = CriticalRouter.GetCriticalRouter(7, connection);
            Assert.AreEqual(3, response.Count);
            Assert.AreEqual(5, response[0][0]);
            Assert.AreEqual(6, response[0][1]);
            Assert.AreEqual(2, response[1][0]);
            Assert.AreEqual(5, response[1][1]);
            Assert.AreEqual(3, response[2][0]);
            Assert.AreEqual(4, response[2][1]);
        }
    }
}
