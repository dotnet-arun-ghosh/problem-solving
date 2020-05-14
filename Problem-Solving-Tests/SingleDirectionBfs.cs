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
    public class SingleDirectionBfsTest
    {
        [TestMethod]
        public void GetSingleDirectionShortestPathShouldReturnValueTwoForGivenGraph()
        {
            var connection = new int[11][];

            connection[0] = new int[] { 0, 8 };
            connection[1] = new int[] { 0, 4 };
            connection[2] = new int[] { 8, 1 };
            connection[3] = new int[] { 1, 3 };
            connection[4] = new int[] { 3, 4 };
            connection[5] = new int[] { 4, 5 };
            connection[6] = new int[] { 5, 7 };
            connection[7] = new int[] { 3, 7 };
            connection[8] = new int[] { 7, 2 };
            connection[9] = new int[] { 2, 1 };
            connection[10] = new int[] { 8, 6 };

            var result = SingleDirectionBfs.GetSingleDirectionShortestPath(9, connection, 0, 2);
        }
    }
}
