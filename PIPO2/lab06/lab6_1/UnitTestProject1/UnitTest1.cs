using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab6_1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Silnia_0()
        {
            silnia S0 = new silnia();
            S0.n = 0;
            Assert.AreEqual(S0.oblicz(), 1);
        }
        [TestMethod]
        public void Silnia_1()
        {
            silnia S1 = new silnia();
            S1.n = 1;
            Assert.AreEqual(S1.oblicz(), 1);
        }
        [TestMethod]
        public void Silnia_5()
        {
            silnia S5 = new silnia();
            S5.n = 5;
            Assert.AreEqual(S5.oblicz(), 120);
        }
    }
}
