using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using System.Xml.Linq;
using System.Collections;
using System.Data;
using System;
using System.Globalization;
namespace TestNPower
{
    [TestClass]
    public  class TestMethodNRoot
    {
        public TestContext TestContext { get; set; }
 
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", 
                    "|DataDirectory|\\DataNumber.xml", 
                    "TestCase",
                    DataAccessMethod.Sequential)]
        [DeploymentItem("\\DataNumber.xml")]
        [TestMethod]
        public void TestCompareNewtonStandart()
        {
  
            var Number = Convert.ToDouble(TestContext.DataRow["number"]);
            var Power = Convert.ToInt32(TestContext.DataRow["power"]);
            var Accurancy = Convert.ToDouble(TestContext.DataRow["accurancy"], CultureInfo.InvariantCulture);
            var actual = SqrtNPower.NPowerRoot.MethodNewton(Number,Power,Accurancy);
            double Expected = Convert.ToDouble(this.TestContext.DataRow["expected"],CultureInfo.InvariantCulture);
            Assert.AreEqual(actual,Expected);
        }
        [TestMethod]
        public void TestMethodNewton()
        {
            double result = SqrtNPower.NPowerRoot.MethodNewton(-27, 3, 0);
            Assert.AreEqual(result, -3);
        }

        [TestMethod]
        public void TestStandartMethod()
        {
            Assert.AreEqual(SqrtNPower.NPowerRoot.StantardMethod(2, 2), 1.4142135623730951);
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestNewton()
        {
            Assert.AreEqual(SqrtNPower.NPowerRoot.MethodNewton(-2, 2), double.NaN);
        }
    }
}
