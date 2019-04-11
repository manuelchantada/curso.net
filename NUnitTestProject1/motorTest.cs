using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using curso.net;
namespace TestProject1
{
    [TestClass]
    public class motorTest
    {

        [TestMethod]
        public void testMotorCreation()
        {
           
            Motor motor = new Motor(100, 10);   
            Assert.IsTrue(motor.getConsumo() == 10);
        }


    }
}
