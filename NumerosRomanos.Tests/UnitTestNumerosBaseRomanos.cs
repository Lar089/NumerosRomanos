using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosRomanos.ConsoleApp.Numeros;
using System;

namespace NumerosRomanos.Tests
{
    [TestClass]
    public class UnitTestNumerosBaseRomanos
    {
        [TestMethod]
        public void ValorRomanoI()
        {
            Assert.AreEqual(1, new ConsoleApp.Numeros.NumerosRomanos("I").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoV()
        {
            Assert.AreEqual(5, new ConsoleApp.Numeros.NumerosRomanos("V").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoX()
        {
            Assert.AreEqual(10, new ConsoleApp.Numeros.NumerosRomanos("X").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoL()
        {
            Assert.AreEqual(50, new ConsoleApp.Numeros.NumerosRomanos("L").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoC()
        {
            Assert.AreEqual(100, new ConsoleApp.Numeros.NumerosRomanos("C").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoD()
        {
            Assert.AreEqual(500, new ConsoleApp.Numeros.NumerosRomanos("D").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoM()
        {
            Assert.AreEqual(1000, new ConsoleApp.Numeros.NumerosRomanos("M").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoIII()
        {
            Assert.AreEqual(3, new ConsoleApp.Numeros.NumerosRomanos("III").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoXXX()
        {
            Assert.AreEqual(30, new ConsoleApp.Numeros.NumerosRomanos("XXX").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoCCC()
        {
            Assert.AreEqual(300, new ConsoleApp.Numeros.NumerosRomanos("CCC").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoMMM()
        {
            Assert.AreEqual(3000, new ConsoleApp.Numeros.NumerosRomanos("MMM").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoIIII()
        {
            Assert.AreEqual(-1, new ConsoleApp.Numeros.NumerosRomanos("IIII").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoVVV()
        {
            Assert.AreEqual(-1, new ConsoleApp.Numeros.NumerosRomanos("VVV").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoLLL()
        {
            Assert.AreEqual(-1, new ConsoleApp.Numeros.NumerosRomanos("LLL").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoVI()
        {
            Assert.AreEqual(6, new ConsoleApp.Numeros.NumerosRomanos("VI").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoVIII()
        {
            Assert.AreEqual(8, new ConsoleApp.Numeros.NumerosRomanos("VIII").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoXI()
        {
            Assert.AreEqual(11, new ConsoleApp.Numeros.NumerosRomanos("XI").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoXIII()
        {
            Assert.AreEqual(13, new ConsoleApp.Numeros.NumerosRomanos("XIII").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoCX()
        {
            Assert.AreEqual(110, new ConsoleApp.Numeros.NumerosRomanos("CX").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoIV()
        {
            Assert.AreEqual(4, new ConsoleApp.Numeros.NumerosRomanos("IV").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoIX()
        {
            Assert.AreEqual(9, new ConsoleApp.Numeros.NumerosRomanos("IX").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoXC()
        {
            Assert.AreEqual(90, new ConsoleApp.Numeros.NumerosRomanos("XC").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoLXII()
        {
            Assert.AreEqual(62, new ConsoleApp.Numeros.NumerosRomanos("LXII").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoCLVIII()
        {
            Assert.AreEqual(158, new ConsoleApp.Numeros.NumerosRomanos("CLVIII").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoMCXX()
        {
            Assert.AreEqual(1120, new ConsoleApp.Numeros.NumerosRomanos("MCXX").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoXL()
        {
            Assert.AreEqual(40, new ConsoleApp.Numeros.NumerosRomanos("XL").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoMCDXLV()
        {
            Assert.AreEqual(1445, new ConsoleApp.Numeros.NumerosRomanos("MCDXLV").numeros_saida);
        }

        [TestMethod]
        public void ValorRomanoMMDXLIII()
        {
            Assert.AreEqual(2543, new ConsoleApp.Numeros.NumerosRomanos("MMDXLIII").numeros_saida);
        }

        [TestMethod]
        public void DeveVerificarV̄ĪĪ()
        {
            Assert.AreEqual(7000, new ConsoleApp.Numeros.NumerosRomanos("V̄ĪĪ").numeros_saida);
        }

        [TestMethod]
        public void DeveVerificarV̄ĪĪĪ()
        {
            Assert.AreEqual(8000, new ConsoleApp.Numeros.NumerosRomanos("V̄ĪĪĪ").numeros_saida);
        }

        [TestMethod]
        public void DeveVerificarĪX̄()
        {
            Assert.AreEqual(10000, new ConsoleApp.Numeros.NumerosRomanos("X̄").numeros_saida);
        }

        [TestMethod]
        public void DeveVerificar4()
        {
            Assert.AreEqual("IV", new ConsoleApp.Numeros.NumerosArabicos(4).numeros_saida);
        }

        [TestMethod]
        public void DeveVerificar10()
        {
            Assert.AreEqual("X", new ConsoleApp.Numeros.NumerosArabicos(10).numeros_saida);
        }

        [TestMethod]
        public void DeveVerificar154()
        {
            Assert.AreEqual("CLIV", new ConsoleApp.Numeros.NumerosArabicos(154).numeros_saida);
        }

        [TestMethod]
        public void DeveVerificar568()
        {
            Assert.AreEqual("DLXVIII", new ConsoleApp.Numeros.NumerosArabicos(568).numeros_saida);
        }

        [TestMethod]
        public void DeveVerificar297()
        {
            Assert.AreEqual("CCXCVII", new ConsoleApp.Numeros.NumerosArabicos(297).numeros_saida);
        }
    }
}
