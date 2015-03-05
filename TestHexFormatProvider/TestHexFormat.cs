using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace TestHexFormatProvider
{
    [TestClass]
    public class TestHexFormat
    {
        [TestMethod]
        public void TestHex1()
        {

            Assert.AreEqual(String.Format(new HexFormatProvider.HexFormat(),"{0:h}",46877), "B71Dh");
        }

        [TestMethod]
        public void TestHex2()
        {
            Assert.AreEqual(String.Format(new HexFormatProvider.HexFormat(), "{0:h}", 1978), "7BAh");
        }

        [TestMethod]
        public void TestHex3()
        {
            Assert.AreEqual(String.Format(new HexFormatProvider.HexFormat(), "{0:C}", 156), "156,00 ₽");
        }
    }
}
