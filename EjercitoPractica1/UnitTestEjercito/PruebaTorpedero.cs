using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercitoPractica1;
using EjercitoPractica1.Models;

namespace UnitTestEjercito
{
    [TestClass]
    class PruebaTorpedero
    {
        [TestMethod]
        public void PruebaAmetralla()
        {
            Torpedero torpedero1 = new Torpedero("to1", 1350, 3, 2, 19);
            Assert.AreEqual(torpedero1.mostrarPrecio(), 1350);
            Assert.AreEqual(torpedero1.resistenciaAlAtaque(), 2);
            Assert.AreEqual(torpedero1.capacidadDeMovimineto(), 3);
            Assert.AreEqual(torpedero1.capacidadDeDestruccion(), 19);
        }
    }
}
