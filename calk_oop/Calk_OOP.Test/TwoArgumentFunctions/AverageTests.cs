using calk_oop.TwoArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.TwoArgumentFunctions
{
    [TestFixture]
    class AverageCalculateTests
    {
        [TestCase(2, 2, 2)]
        [TestCase(4, 6, 5)]
        [TestCase(1, 3, 2)]
        public void CalculateTest(double arOne, double arTwo, double expected)
        {
            var calculator = new Average();
            var actualResult = calculator.Calculate(arOne, arTwo);
            Assert.AreEqual(expected, actualResult);
        }
    }
}