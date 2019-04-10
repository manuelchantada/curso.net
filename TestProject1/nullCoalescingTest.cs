using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class nullCoalescingTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double? num1 = null;
            double? num2 = 3.14157;
            double? num3;
            num3 = num1 ?? num2;
            Console.WriteLine(num3);
            Assert.IsTrue(num3 == num2);
        }
    }
}
