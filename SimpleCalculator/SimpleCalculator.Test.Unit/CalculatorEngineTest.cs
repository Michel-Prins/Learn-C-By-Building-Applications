using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("add", number1, number2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SubstractTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 2;
            int number2 = 1;
            double result = _calculatorEngine.Calculate("subtract", number1, number2);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SubstractTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 2;
            int number2 = 1;
            double result = _calculatorEngine.Calculate("-", number1, number2);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MultiplyTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 2;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("multiply", number1, number2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MultiplyTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 2;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("*", number1, number2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void DivideTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 2;
            int number2 = 1;
            double result = _calculatorEngine.Calculate("divide", number1, number2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 2;
            int number2 = 1;
            double result = _calculatorEngine.Calculate("/", number1, number2);
            Assert.AreEqual(2, result);
        }
    }
}
