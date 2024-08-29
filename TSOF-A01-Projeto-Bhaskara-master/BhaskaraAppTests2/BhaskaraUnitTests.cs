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
    public class BhaskaraUnitTests
    {
        [TestMethod()]
        [DataRow(-2, -10, 28, 324)]
        [DataRow(-4, -20, 28, 848)]
        [DataRow(50, 7, 3, -551)]
        [DataRow(1, -10, 25, 0)]
        public void CalcularDeltaUnitTest(double a, double b, double c, double esperado)
        {
            Bhaskara bhaskara = new Bhaskara(a, b, c);

            double obtido = bhaskara.CalcularDelta();

            Assert.AreEqual(esperado, obtido);
        }

        [TestMethod()]
        [DataRow(-2, -10, 28, true)]
        [DataRow(-4, -20, 28, true)]
        [DataRow(50, 7, 3, false)]
        public void TemRaizesReaisUnitTest(double a, double b, double c, bool esperado)
        {
            Bhaskara bhaskara = new Bhaskara(a, b, c);

            bool obtido = bhaskara.TemRaizesReais();

            Assert.AreEqual(esperado, obtido);
        }


        [TestMethod()]
        [DataRow(-2, -10, 28, -7, 2)]
        [DataRow(-20, -20, 28, -1.78, 0.78)]
        public void CalcularRaizesUnitTest(double a, double b, double c, double R1, double R2)
        {
            Bhaskara bhaskara = new Bhaskara(a, b, c);

            var (raiz1, raiz2) = bhaskara.CalcularRaizes();

            bool RaizIgual = (R1 == Math.Round((double)raiz1, 2)) && (R2 == Math.Round((double)raiz2, 2));



            Assert.IsTrue(RaizIgual);
        }


        [TestMethod()]
        [DataRow(50, 7, 3, null, null)]
        public void CalcularRaizesCapetaUnitTest(double a, double b, double c, double? R1, double? R2)
        {
            Bhaskara bhaskara = new Bhaskara(a, b, c);

            var (raiz1, raiz2) = bhaskara.CalcularRaizes();

            bool RaizIgual = (raiz1 == R1) && (R2 == raiz2);

            Assert.IsTrue(RaizIgual);

        }
    }
}