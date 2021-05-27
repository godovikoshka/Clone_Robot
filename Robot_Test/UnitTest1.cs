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

        [TestMethod]
        public void TestMethod2()
        {
            var R2D2 = new Robot("aass22", "red", 190, 30, 15);
            var result = R2D2.Clone();
            Assert.AreEqual(result.model, R2D2.model);
            Assert.AreEqual(result.color, R2D2.color);
            Assert.AreEqual(result.height, R2D2.height);
            Assert.AreEqual(result.width, R2D2.width);
            Assert.AreEqual(result.length, R2D2.length);
        }
    }
}
