using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operation.Tests
{
    [TestClass()]
    public class SquareTests
    {
        private readonly double c = 2.5;
        private readonly int a = 4;
        [TestMethod()]
        public void SquaredTest()
        {
            Assert.AreEqual(2.7, Operation.Square.Squared(c));
        }

        [TestMethod()]
        public void SquaredTest1()
        {
            Assert.AreEqual(2.7, Operation.Square.Squared(a));
        }
    }
}