using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercitoPractica1;
using EjercitoPractica1.Models;

namespace UnitTestEjercito
{
    [TestClass]
    public class PruebaAmetrallador
    {
        [TestMethod]
        public void PruebaAmetralla()
        {
            Ametrallador ametrallador1 = new Ametrallador("am1", 400, 4, 10);
            Assert.AreEqual(ametrallador1.mostrarPrecio(), 400);
            Assert.AreEqual(ametrallador1.resistenciaAlAtaque(), 10);
        }
    }
}
