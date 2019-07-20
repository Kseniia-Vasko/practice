using calk_oop.OneArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.OneArgumentFunctions
{
    [TestFixture]
    class ExponentaCalculateTests
    {
        [TestCase(0, 1)]
        [TestCase(2, 7.389)]
        [TestCase(4, 54.598)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Exponent();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}