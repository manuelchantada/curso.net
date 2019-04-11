using Microsoft.VisualStudio.TestTools.UnitTesting;
using curso.net;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Accessors()
        {
            Accessible acc = new Obj();
            acc.PrivateVariable = 1;
            Assert.IsTrue(acc.PrivateVariable == 1);

        }

        [TestMethod]
        public void Indexers()
        {
            Indexer names = new Indexer();
            names[0] = "flor";
            names[5] = "manu";

            Assert.AreEqual(names[0], "flor");
            Assert.AreEqual(names[5], "manu");

        }
    }
}
 