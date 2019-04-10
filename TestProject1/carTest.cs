using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using curso.net;

namespace TestProject1
{
    [TestClass]
    public class carTest
    {
        [TestMethod]
        public void getAutonomia()
        {
            Auto auto = new Auto("volkswagen", 2010, new Motor(100, 10), 50);
            auto.cargarNafta(50);
            Assert.IsTrue(auto.getAutonomia() == 500);
        }

        [TestMethod]
        public void testLuces() {
            Auto auto = new Auto("volkswagen", 2010, new Motor(100, 10), 50);
            auto.Luces[0] = new Luz("blanca");
            auto.Luces[2] = new Luz("roja");
            Assert.IsTrue(auto.Luces[0].color == "blanca");
            Assert.IsTrue(auto.Luces[2].color == "roja");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "La cantidad de litros a cargar excede la capacidad del auto.")]
        public void cargarNaftaDeMasThrows()
        {
            Auto auto = new Auto("volkswagen", 2010, new Motor(100, 10), 50);
            auto.cargarNafta(40);
            auto.cargarNafta(11);
        }
    }
}
