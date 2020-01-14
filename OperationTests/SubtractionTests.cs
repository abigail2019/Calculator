﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        private readonly double[] e = { 6.02, 1.3, 2.5 };
        private readonly int[] f = { 30, 3, 2, 5 };
        [TestMethod()]
        public void SubtractDoubleTest()
        {
            Assert.AreEqual(2.7, Operation.Subtraction.Subtract(c, d));
        }

        [TestMethod()]
        public void SubtractIntTest1()
        {
            Assert.AreEqual(5, Operation.Subtraction.Subtract(a, b));
        }

        [TestMethod()]
        public void SubtractDoubleArrayTest2()
        {
            Assert.AreEqual(-9.82, Subtraction.Subtract(e));
        }

        [TestMethod()]
        public void SubtractIntArrayTest3()
        {
            Assert.AreEqual(-40, Subtraction.Subtract(f));
        }
    }
}