using calk_oop.OneArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.OneArgumentFunctions
{
    [TestFixture]
    class CotangensCalculateTests
    {
        [TestCase(1, 0.642)]
        [TestCase(0.5, 1.830)]
        [TestCase(0.75, 1.073)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Cotangens();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}