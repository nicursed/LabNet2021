using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivCero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivCero.Tests
{
    [TestClass()]
    public class DivCeroExceptionTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionPorCeroTest()
        {
            //Arrange
            int i = 10;
            int j = 0;

            //Act
            DivCeroException.DivisionPorCero(i, j);

            //Assert
            //Handled by Expected Exception
        }

        [TestMethod()]
        public void ResultadoTest()
        {
            //Arrange
            int i = 50;
            int j = 2;
            int esperado = 25;

            //Act
            int resultado = DivCeroException.DivisionPorCero(i, j);

            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}