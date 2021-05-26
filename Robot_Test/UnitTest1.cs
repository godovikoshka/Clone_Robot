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

        [TestMethod]
        public void TestMethod3()
        {
            var R3D3 = new Robot("zzxx33", "green", 125, 75, 45);
            var result = R3D3.Clone();
            Assert.AreEqual(result.model, R3D3.model);
            Assert.AreEqual(result.color, R3D3.color);
            Assert.AreEqual(result.height, R3D3.height);
            Assert.AreEqual(result.width, R3D3.width);
            Assert.AreEqual(result.length, R3D3.length);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var R4D4 = new Robot("ccvv44", "yellow", 100, 100, 100);
            var result = R4D4.Clone();
            Assert.AreEqual(result.model, R4D4.model);
            Assert.AreEqual(result.color, R4D4.color);
            Assert.AreEqual(result.height, R4D4.height);
            Assert.AreEqual(result.width, R4D4.width);
            Assert.AreEqual(result.length, R4D4.length);
        }
    }
}
