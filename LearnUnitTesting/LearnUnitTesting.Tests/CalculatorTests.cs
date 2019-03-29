using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LearnUnitTesting.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Sum_twoperam_correctresult()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            double result = calculator.Sum(10, 12);

            //Assert
            Assert.AreEqual(result, 22);
        }
    }
}
