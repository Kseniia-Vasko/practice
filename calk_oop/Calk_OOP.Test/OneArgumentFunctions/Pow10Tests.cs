using calk_oop.OneArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.OneArgumentFunctions
{
    [TestFixture]
    class Pow10CalculateTests
    {
        [TestCase(2, 100)]
        [TestCase(3, 1000)]
        [TestCase(5, 100000)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Pow10();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult);
        }
    }
}