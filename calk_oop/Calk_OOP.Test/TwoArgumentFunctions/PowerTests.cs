using calk_oop.TwoArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.TwoArgumentFunctions
{
    [TestFixture]
    class PowerCalculateTests
    {
        [TestCase(4, 2, 16)]
        [TestCase(1, 4, 1)]
        [TestCase(5, 3, 125)]
        public void CalculateTest(double arOne, double arTwo, double expected)
        {
            var calculator = new Power();
            var actualResult = calculator.Calculate(arOne, arTwo);
            Assert.AreEqual(expected, actualResult);
        }
    }
}