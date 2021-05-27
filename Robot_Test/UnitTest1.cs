using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clone;

namespace Robot_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var R1D1 = new Robot("qqww11", "blue", 150, 50, 30);
            var result = R1D1.Clone();
            Assert.AreEqual(result.model, R1D1.model);
            Assert.AreEqual(result.color, R1D1.color);
            Assert.AreEqual(result.height, R1D1.height);
            Assert.AreEqual(result.width, R1D1.width);
            Assert.AreEqual(result.length, R1D1.length);
        }
    }
}
