using System;
using calk_oop.TwoArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.TwoArgumentFunctions
{
    [TestFixture]

    class TwoArgumentFactoryTests
    {
        [TestCase("Add", typeof(Adder))]
        [TestCase("Subtraction", typeof(Subtracter))]
        [TestCase("Multiplication", typeof(Multipier))]
        [TestCase("Divide", typeof(Divider))]
        [TestCase("Power", typeof(PowerB))]
        [TestCase("Log", typeof(Logarithm))]
        [TestCase("Min", typeof(Minimum))]
        [TestCase("Max", typeof(Maximum))]
        [TestCase("Avg", typeof(Average))]
        [TestCase("Pow", typeof(Power))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}