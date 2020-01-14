using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operation.Tests
{

    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 10;
        private readonly int b = 2;
        private readonly double c = 20.5;
        private readonly double d = 10.0;
        private readonly double[] arrayA = { 23.25, 2.5, 6.2 };
        private readonly int[] arrayB = { 40, 2,6, 3 };

        [TestMethod()]
        public void DivsionTest()
        {
            Assert.AreEqual(5, Operation.Division.Divsion(a, b));
        }

        [TestMethod()]
        public void DivsionTest1()
        {
            Assert.AreEqual(2.05, Operation.Division.Divsion(c, d));
        }

        [TestMethod()]
        public void DivsionTest2()
        {
            Assert.AreEqual(1.5, Operation.Division.Divsion(arrayA));
        }

        [TestMethod()]
        public void DivsionTest3()
        {
            Assert.AreEqual(1, Operation.Division.Divsion(arrayB));
        }
    }
}