using calk_oop.OneArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.OneArgumentFunctions
{
    [TestFixture]
    class AnotherpowerCalculateTests
    {
        [TestCase(1, 1)]
        [TestCase(4, 16)]
        [TestCase(9, 81)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Anotherpower();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult);
        }
    }
}