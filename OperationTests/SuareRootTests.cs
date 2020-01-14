using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operation.Tests
{
    [TestClass()]
    public class SuareRootTests
    {
        private readonly int a = 16;
        [TestMethod()]
        public void RootTest()
        {
            Assert.AreEqual(4, Operation.SuareRoot.Root(a));
        }
    }
}