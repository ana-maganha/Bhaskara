using Microsoft.VisualStudio.TestTools.UnitTesting;
using BhaskaraApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhaskaraApp.Tests
{
    [TestClass()]
    public class BhaskaraTests
    {
        private Bhaskara bhaskara;


        public void inicializar()
        {
            bhaskara = new Bhaskara(0, 0, 0);
        }

        [TestMethod()]
        [DataRow(-20, -15, 81, 1.672)]
        public void BhaskaraBhaskaraTest(double a, double b, double c, double esperado)
        {
            //ACT
            double obtido = bhaskara.CalcularDelta(a, b, c);
            Assert.Fail();
        }

        [TestMethod()]
        [DataRow(-20, -15, 81, 1.672)]
        public void TemRaizesReaisBhaskaraTest(double a, double b, double c, double esperado)
        {
            Assert.Fail();
        }

        [TestMethod()]
        [DataRow(-20, -15, 81, 1.672)]
        public void CalcularRaizesBhaskaraTest(double a, double b, double c, double esperado)
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BhaskaraBhaskaraUnitTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CalcularDeltaBhaskaraUnitTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void TemRaizesReaisBhaskaraUnitTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CalcularRaizesBhaskaraUnitTest()
        {
            Assert.Fail();
        }
    }
}