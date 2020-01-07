using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operation.Tests
{
    [TestClass()] //attribute
    public class AdditionTests
    {
        private readonly int a = 10;
        private readonly int b = 20;
        private readonly double c = 5.5;
        private readonly double d = 10.4;
        private readonly double[] arrayA = { 10.4, 20.5, 3.4 };

        [TestMethod()]
        public void SumTest()
        {

            Assert.AreEqual(30, Operation.Addition.Sum(a, b));
        }

        //[TestMethod()]
        //public void SumTest()
        //{
        //    Assert.AreEqual(15.9, Operation.Addition.Sum(c, d));
        //}

        [TestMethod()]
        public void SumTest1()
        {
            Assert.AreEqual(34.3, Operation.Addition.Sum(arrayA));
        }

        [TestMethod()]
        public void SumTest2()
        {
            Assert.AreEqual(15.9, Operation.Addition.Sum(c, d));
        }

        //[TestMethod()]
        //public void DivisionTest()
        //{
        //    Assert.Fail();
        //}
    }
}