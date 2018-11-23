using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gateware.Tests
{
    [TestClass]
    public class Exercicio03
    {
        [TestMethod]
        public void Executar()
        {
            Assert.IsTrue(Negocio.Exercicio03.Solucao01());
        }
    }
}
