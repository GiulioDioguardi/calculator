using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorTests
    {
        Operations calculations = new Operations();
        [TestMethod]
        public void AddTest()
        {
            double result = calculations.NormalOperation("+", 2, 2);
            Assert.AreEqual(4, result);
            result = calculations.NormalOperation("+", -4, 2);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void SubstractTest()
        {
            double result = calculations.NormalOperation("-", 4, 2);
            Assert.AreEqual(2, result);
            result = calculations.NormalOperation("-", 2, 4);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            double result = calculations.NormalOperation("*", 4, 2);
            Assert.AreEqual(8, result);
            result = calculations.NormalOperation("*", -2, 4);
            Assert.AreEqual(-8, result);
            result = calculations.NormalOperation("*", 2.51, 4);
            Assert.AreEqual(10.04, result);
        }

        [TestMethod]
        public void DivisionTest()
        {
            double result = calculations.NormalOperation("/", 4, 2);
            Assert.AreEqual(2, result);
            result = calculations.NormalOperation("/", 4.6, 2);
            Assert.AreEqual(2.3, result);
            result = calculations.NormalOperation("/", 10, 0);
            Assert.AreEqual(double.PositiveInfinity, result);
            result = calculations.NormalOperation("/", -10, 0);
            Assert.AreEqual(double.NegativeInfinity, result);
        }
    }
}
