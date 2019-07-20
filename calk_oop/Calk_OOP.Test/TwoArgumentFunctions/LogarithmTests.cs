using calk_oop.TwoArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.TwoArgumentFunctions
{
    [TestFixture]
    class LogarithmCalculateTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(16, 2, 4)]
        [TestCase(125, 5, 3)]
        public void CalculateTest(double arOne, double arTwo, double expected)
        {
            var calculator = new Logarithm();
            var actualResult = calculator.Calculate(arOne, arTwo);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new Logarithm();
            Assert.Throws<System.Exception>(() => calculator.Calculate(-4, 1));
        }
    }
}