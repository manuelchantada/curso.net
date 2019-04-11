using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using curso.net;
namespace StaticTest
{
    [TestClass]
    public class StaticTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            StaticMember staticObj = new StaticMember();

            Assert.IsTrue(StaticMember.Count == 1);
        }
    }
}
