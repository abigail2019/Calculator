using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operation.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly double c = 5.7;
        private readonly double d = 3.0;
        private readonly int a = 10;
        private readonly int b = 5;
        [TestMethod()]
        public void SubtractTest()
        {
            Assert.AreEqual(2.7, Operation.Subtraction.Subtract(c, d));
        }

        [TestMethod()]
        public void SubtractTest1()
        {
            Assert.AreEqual(5, Operation.Subtraction.Subtract(a, b));
        }
    }
}