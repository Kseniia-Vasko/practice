using System;
using calk_oop.OneArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.OneArgumentFunctions
{
    [TestFixture]

    class OneArgumentsFactoryTests
    {
        [TestCase("Sin", typeof(Sinus))]
        [TestCase("Cos", typeof(Cosinus))]
        [TestCase("Exp", typeof(Exponenta))]
        [TestCase("Tan", typeof(Tangens))]
        [TestCase("Arcsin", typeof(Arcsinus))]
        [TestCase("Arccos", typeof(Arccosinus))]
        [TestCase("Arctan", typeof(Arctangens))]
        [TestCase("Abs", typeof(Mod))]
        [TestCase("Ln", typeof(LogarithmN))]
        [TestCase("Lg", typeof(Logarithm10))]
        [TestCase("Neg", typeof(Negation))]
        [TestCase("Pw", typeof(Power2))]
        [TestCase("Pwr", typeof(Pow10))]
        [TestCase("Back", typeof(Divideback))]
        [TestCase("Pwer", typeof(Anotherpower))]
        [TestCase("Ctg", typeof(Cotangens))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}