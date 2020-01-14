using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operation.Tests
{
    [TestClass()]
    public class CubeTests
    {
        private readonly int a = 2;
        private readonly double c = 4.5;
        [TestMethod()]
        public void CubedTest()
        {
            Assert.AreEqual(91.125, Operation.Cube.Cubed(c));
        }

        [TestMethod()]
        public void CubedTest1()
        {
            Assert.AreEqual(8, Operation.Cube.Cubed(a));
        }
    }
}