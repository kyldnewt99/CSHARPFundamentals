using System;
using _09_Interfaces_WorkingWithDI.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Interfaces_WorkingWithDI
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void PennyTest()
        {
            var penny = new Penny();
            Assert.AreEqual(0.01m, penny.Value);
            Assert.AreEqual("Penny", penny.Name);
        }

        //for extra practice, build tests for other classes
        [DataTestMethod]
        [DataRow(100.2)]
        [DataRow(.52)]
        [DataRow(42.42)]
        [DataRow(60000.001)]
        [DataRow(19)]
        [DataRow(37.2065)]
        public void EPaymentTests(double value)
        {
            decimal convertedValue = Convert.ToDecimal(value);
            var ePayment = new ElectronicPayment(convertedValue);
            Assert.AreEqual(convertedValue, ePayment.Value);
            Assert.AreEqual("Electronic Payment", ePayment.Name);
        }
    }
}
