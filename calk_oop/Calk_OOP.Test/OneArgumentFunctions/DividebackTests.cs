using calk_oop.OneArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.OneArgumentFunctions
{
    [TestFixture]
    class DividebackCalculateTests
    {
        [TestCase(1, 1)]
        [TestCase(10, 0.1)]
        [TestCase(2, 0.5)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Divideback();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult);
        }
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new Divideback();
            Assert.Throws<System.Exception>(() => calculator.Calculate(0));
        }
    }
}