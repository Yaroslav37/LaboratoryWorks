using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a, b, c;
            a = 10; b = 2;
            c = a / b;
            Assert.AreEqual(5, c);
        }
    }

    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            int a, b, c;
            a = 1; b = 228;
            c = a / b;
            Assert.AreEqual(0, c);
        }
    }
}
