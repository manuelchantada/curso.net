using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using curso.net;
namespace TestProject1
{
    [TestClass]
    public class exchangeUnsafeTest
    {
        [TestMethod]
        unsafe public void TestMethod1()
        {
            int a = 1; int b = 2;
            Program.exchange(&a, &b);
            Assert.IsTrue(a==2 & b==1);

        }
    }
}
