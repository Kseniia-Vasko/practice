using calk_oop.OneArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.OneArgumentFunctions
{
    [TestFixture]
    class ArccosinusCalculateTests
    {
        [TestCase(0.1, 1.470)]
        [TestCase(1, 0)]
        [TestCase(0.5, 1.047)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Arccosinus();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new Arccosinus();
            Assert.Throws<System.Exception>(() => calculator.Calculate(-4));
        }
    }
}