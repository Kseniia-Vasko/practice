using calk_oop.OneArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.OneArgumentFunctions
{
    [TestFixture]
    class Power2CalculateTests
    {
        [TestCase(2, 4)]
        [TestCase(3, 8)]
        [TestCase(5, 32)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Power2();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult);
        }
    }
}