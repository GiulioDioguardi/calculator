using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorTests
    {
        double result;
        [TestMethod]
        public void AddTest()
        {
            result = Operations.NormalOperation("+", 2, 2);
            Assert.AreEqual(4, result);
            result = Operations.NormalOperation("+", -4, 2);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void SubstractTest()
        {
            result = Operations.NormalOperation("-", 4, 2);
            Assert.AreEqual(2, result);
            result = Operations.NormalOperation("-", 2, 4);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            result = Operations.NormalOperation("*", 4, 2);
            Assert.AreEqual(8, result);
            result = Operations.NormalOperation("*", -2, 4);
            Assert.AreEqual(-8, result);
            result = Operations.NormalOperation("*", 2.51, 4);
            Assert.AreEqual(10.04, result);
        }

        [TestMethod]
        public void DivisionTest()
        {
            result = Operations.NormalOperation("/", 4, 2);
            Assert.AreEqual(2, result);
            result = Operations.NormalOperation("/", 4.6, 2);
            Assert.AreEqual(2.3, result);
            result = Operations.NormalOperation("/", 10, 0);
            Assert.AreEqual(double.PositiveInfinity, result);
            result = Operations.NormalOperation("/", -10, 0);
            Assert.AreEqual(double.NegativeInfinity, result);
        }

        [TestMethod]
        public void ModuloTest()
        {
            result = Operations.NormalOperation("%", 5, 2);
            Assert.AreEqual(1, result);
            result = Operations.NormalOperation("%", 5, 0);
            Assert.AreEqual(double.NaN, result);
        }

        [TestMethod]
        public void PowerTest()
        {
            result = Operations.NormalOperation("^", 5, 2);
            Assert.AreEqual(25, result);
            result = Operations.NormalOperation("^", 2, 10);
            Assert.AreEqual(1024, result);
        }

        [TestMethod]
        public void PowerRootTest()
        {
            result = Operations.NormalOperation("y rt(x)", 27, 3);
            Assert.AreEqual(3, result);
        }
    }
}
