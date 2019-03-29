using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autofac.Extras.Moq;
using LearnUnitTesting.Second;

namespace LearnUnitTesting.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        
        [TestMethod]
        public void CalculatorSum_twoinput_correctOutput()
        {
            using (var mock= AutoMock.GetLoose())
            {
                // Arrange
                mock.Mock<IMathLibrary>().Setup(x => x.MathLibraySum(3, 5)).Returns(8);
                var calculator = mock.Create<Calculator>();

                // Act
                var result = calculator.CalculatorSum(3,5);

                // Assert
                mock.Mock<IMathLibrary>().Verify(x=> x.MathLibraySum(3,5));
                Assert.AreEqual(8,result);
            }

        }
    }
}
