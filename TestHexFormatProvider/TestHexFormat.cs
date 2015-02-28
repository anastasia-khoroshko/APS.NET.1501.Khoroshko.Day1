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
            HexFormatProvider.HexFormat number = new HexFormatProvider.HexFormat(46877);
            Assert.AreEqual(String.Format(number.ToString("h", CultureInfo.CurrentCulture)), "B71Dh");
        }

        [TestMethod]
        public void TestHex2()
        {
            HexFormatProvider.HexFormat number = new HexFormatProvider.HexFormat(1978);
            Assert.AreEqual(String.Format(number.ToString("h")), "7BAh");
        }

        [TestMethod]
        public void TestHex3()
        {
            HexFormatProvider.HexFormat number = new HexFormatProvider.HexFormat(156);
            Assert.AreEqual(String.Format(number.ToString()), "9Ch");
        }
    }
}
