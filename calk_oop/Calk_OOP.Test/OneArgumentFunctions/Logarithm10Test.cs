using calk_oop.OneArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.OneArgumentFunctions
{
    [TestFixture]
    class Logarithm10CalculateTests
    {
        [TestCase(1,0)]
        [TestCase(10, 1)]
        [TestCase(2, 0.301)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Logarithm10();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}