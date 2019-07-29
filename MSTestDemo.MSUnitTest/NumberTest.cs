using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestDemo;

namespace MSTestDemo.MSUnitTest
{
    [TestClass]
    public class NumberTest
    {
        [TestMethod]
        public void CalculateSum_SumOfIntegers_ReturnsTotal()
        {
            //Arrange
            var number = new Number();

            //Act
            var result = number.CalculateSum(10, 20);

            //Assert
            Assert.AreEqual(result, 30);
        }

        [TestMethod]
        public void CalculateSum_SumOfIntegers_ReturnsTotalNotEqual()
        {
            var number = new Number();

            var result = number.CalculateSum(10, 20);

            Assert.AreNotEqual(result, 20);
        }
    }
}
