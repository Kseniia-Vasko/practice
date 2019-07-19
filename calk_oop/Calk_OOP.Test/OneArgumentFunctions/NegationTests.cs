using calk_oop.OneArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.OneArgumentFunctions
{
    [TestFixture]
    class NegationCalculateTests
    {
        [TestCase(1, -1)]
        [TestCase(10, -10)]
        [TestCase(2, -2)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Negation();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult);
        }
    }
}