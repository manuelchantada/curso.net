using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestProject1
{
    [TestClass]
    public class FileWriteReadTest
    {
        const string fileName = "test.txt";
        string textToWrite = "this is a test";
        string textRead;

        [TestMethod]
        public void writtenTextIsRead()
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(textToWrite);
            }

            using(StreamReader sr = new StreamReader(fileName))
            {
                textRead = sr.ReadLine();
            }

            Assert.IsTrue(textToWrite == textRead);

        }

    }
}
