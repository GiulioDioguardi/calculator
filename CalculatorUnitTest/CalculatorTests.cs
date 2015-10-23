using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorTests
    {
        Operations calculations = new Operations();
        double result;
        [TestMethod]
        public void AddTest()
        {
            result = calculations.NormalOperation("+", 2, 2);
            Assert.AreEqual(4, result);
            result = calculations.NormalOperation("+", -4, 2);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void SubstractTest()
        {
            result = calculations.NormalOperation("-", 4, 2);
            Assert.AreEqual(2, result);
            result = calculations.NormalOperation("-", 2, 4);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            result = calculations.NormalOperation("*", 4, 2);
            Assert.AreEqual(8, result);
            result = calculations.NormalOperation("*", -2, 4);
            Assert.AreEqual(-8, result);
            result = calculations.NormalOperation("*", 2.51, 4);
            Assert.AreEqual(10.04, result);
        }

        [TestMethod]
        public void DivisionTest()
        {
            result = calculations.NormalOperation("/", 4, 2);
            Assert.AreEqual(2, result);
            result = calculations.NormalOperation("/", 4.6, 2);
            Assert.AreEqual(2.3, result);
            result = calculations.NormalOperation("/", 10, 0);
            Assert.AreEqual(double.PositiveInfinity, result);
            result = calculations.NormalOperation("/", -10, 0);
            Assert.AreEqual(double.NegativeInfinity, result);
        }

        [TestMethod]
        public void ModuloTest()
        {
            result = calculations.NormalOperation("%", 5, 2);
            Assert.AreEqual(1, result);
            result = calculations.NormalOperation("%", 5, 0);
            Assert.AreEqual(double.NaN, result);
        }

        [TestMethod]
        public void PowerTest()
        {
            result = calculations.NormalOperation("^", 5, 2);
            Assert.AreEqual(25, result);
            result = calculations.NormalOperation("^", 2, 10);
            Assert.AreEqual(1024, result);
        }

        [TestMethod]
        public void PowerRootTest()
        {
            result = calculations.NormalOperation("y rt(x)", 27, 3);
            Assert.AreEqual(3, result);
        }
    }
}
