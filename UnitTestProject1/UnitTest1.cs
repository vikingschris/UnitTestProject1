using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bank bOne = new Bank(1500.0);
            bOne.deposit(300.0);
            Assert.AreEqual(1800.0, bOne.gsBalance);
        }
        [TestMethod]
        public void testString()
        {
            Bank bTwo = new Bank(1500.0);
            StringAssert.Contains("TDBank", bTwo.bankName());
        }
    }
}
