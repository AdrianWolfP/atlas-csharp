using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        int[,] testmatrix;
        int[] posFive = { 1, 2, 3, 4, 5 }, negFive = { -1, -2, -3, -4, -5 },
        centerPos = { 1, 2, 5, 3, 4 }, centerNeg = {-1, -2, -5, -3, -4 };
        List<int> testList;
        [Setup]
        public void Setup()
        {
            testmatrix = new int[2, 2];
            testmatrix[0, 0] = 2;
            testmatrix[0, 1] = 4;
            testmatrix[1, 0] = 6;
            testmatrix[1, 1] = 8;
            testList = new List<int>();
        }

        public void NormalFunction(int value)
        {
            Assert.Pass();

        }

        public void NullReturn()
        {
            Assert.Pass();

        }

        public void  DivideByZero()
        {
         Assert.Pass();

        }

        [Test]
        public void MaxOfNone()
        {
            Assert.AreEqual(0, MyMath.Operations.Max(new List<int>()));

        }

        [Test]
        public void MaxofFive()
    }
}