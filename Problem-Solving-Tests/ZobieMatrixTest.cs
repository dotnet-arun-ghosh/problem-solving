using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_Solving;

namespace Problem_Solving_Tests
{
    [TestClass]
    public class ZobieMatrixTest
    {
        [TestMethod]
        public void CalculateZombieMatrixTimeMethodShouldReturnZeroWhenAllItemInMatrixIsOne()
        {
            int[,] array = new int[,]
            {
                {1,1,1,1 },
                {1,1,1,1 },
                {1,1,1,1 },
                {1,1,1,1 },
                {1,1,1,1 },
                {1,1,1,1 }
            };

            var response = ZombieMatrix.CalculateZombieMatrixTime(array);

            Assert.AreEqual(0, response);
        }

        public void CalculateZombieMatrixTimeMethodShouldReturnZeroWhenAllItemInMatrixIsOneExceptOne()
        {
            int[,] array = new int[,]
            {
                {1,1,1,1 },
                {1,1,1,1 },
                {1,1,1,1 },
                {1,1,0,1 },
                {1,1,1,1 },
                {1,1,1,1 }
            };

            var response = ZombieMatrix.CalculateZombieMatrixTime(array);

            Assert.AreEqual(1, response);
        }

        [TestMethod]
        public void CalculateZombieMatrixTimeMethodShouldReturnZeroWhenAllItemInMatrixIsZero()
        {
            int[,] array = new int[,]
            {
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 }
            };

            var response = ZombieMatrix.CalculateZombieMatrixTime(array);

            Assert.AreEqual(0, response);
        }

        [TestMethod]
        public void CalculateZombieMatrixTimeMethodShouldReturnOneWhenBelowGivenMatrixIsPassed()
        {
            int[,] area = new int[,]
            {
                { 0, 1, 0, 1, 0 },
                { 1, 0, 1, 0, 1 },
                { 0, 1, 0, 1, 0 },
                { 1, 0, 1, 0, 1 }
            };

            var response = ZombieMatrix.CalculateZombieMatrixTime(area);

            Assert.AreEqual(1, response);
        }

        [TestMethod]
        public void CalculateZombieMatrixTimeMethodShouldReturnTwoWhenBelowGivenMatrixIsPassed()
        {
            int[,] area = new int[,]
            {
                { 0, 1, 1, 0, 1 },
                { 0, 1, 0, 1, 0 },
                { 0, 0, 0, 0, 1 },
                { 0, 1, 0, 0, 0 }
            };

            var response = ZombieMatrix.CalculateZombieMatrixTime(area);

            Assert.AreEqual(2, response);
        }

        [TestMethod]
        public void CalculateZombieMatrixTimeMethodShouldReturnSevenWhenBelowGivenMatrixIsPassed()
        {
            int[,] area = new int[,]
            {
                { 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }
            };

            var response = ZombieMatrix.CalculateZombieMatrixTime(area);

            Assert.AreEqual(7, response);
        }

        [TestMethod]
        public void CalculateZombieMatrixTimeMethodShouldReturnZeroWhenBelowGivenMatrixIsHavingOneValuZero()
        {
            int[,] area = new int[,]
            {
                { 0 }
            };

            var response = ZombieMatrix.CalculateZombieMatrixTime(area);

            Assert.AreEqual(0, response);
        }

        [TestMethod]
        public void CalculateZombieMatrixTimeMethodShouldReturnZeroWhenBelowGivenMatrixIsHavingOneValueOne()
        {
            int[,] area = new int[,]
            {
                { 1 }
            };

            var response = ZombieMatrix.CalculateZombieMatrixTime(area);

            Assert.AreEqual(0, response);
        }
    }
}
