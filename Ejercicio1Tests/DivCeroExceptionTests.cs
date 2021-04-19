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
        public void DivByZeroThrowsException()
        {
            //Arrange
            int i = 10;
            int j = 0;

            //Act
            DivCeroException.DivisionPorCero(i, j);

            //Assert
            //Handled by Expected Exception

        }
    }
}