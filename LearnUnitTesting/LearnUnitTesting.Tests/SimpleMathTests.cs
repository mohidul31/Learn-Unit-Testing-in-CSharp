using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LearnUnitTesting.Tests
{
    [TestClass]
    public class SimpleMathTests
    {
        [TestMethod]
        public void Sum_twoperam_correctresult()
        {
            //Arrange
            SimpleMath calculator = new SimpleMath();

            //Act
            double result = calculator.Sum(10, 12);

            //Assert
            Assert.AreEqual(result, 22);
        }
    }
}
