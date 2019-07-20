using calk_oop.OneArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.OneArgumentFunctions
{
    [TestFixture]
    class LogarithmNCalculateTests
    {
        [TestCase(2, 0.693)]
        [TestCase(1, 0)]
        [TestCase(0.5, -0.693)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new LogarithmN();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new LogarithmN();
            Assert.Throws<System.Exception>(() => calculator.Calculate(-4));
        }
    }
}