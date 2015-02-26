using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNPower
{
    [TestClass]
    public class TestMethodNRoot
    {
        [TestMethod]
        public void TestCompareNewtonStandart()
        {
            double result = SqrtNPower.NPowerRoot.MethodNewton(27, 3, 0);
            Assert.AreEqual(result, SqrtNPower.NPowerRoot.StantardMethod(27, 3));
        }
        [TestMethod]
        public void TestMethodNewton()
        {
            double result = SqrtNPower.NPowerRoot.MethodNewton(-27, 3, 0.001);
            Assert.AreEqual(result, Double.NaN);
        }

        [TestMethod]
        public void TestStandartMethod()
        {
            Assert.AreEqual(SqrtNPower.NPowerRoot.StantardMethod(2, 2), 1.4142135623730951);
        }
        [TestMethod]
        public void TestNewton()
        {
            Assert.AreEqual(SqrtNPower.NPowerRoot.MethodNewton(2, 2, 0.001), 1.4142135623746899);
        }
    }
}
