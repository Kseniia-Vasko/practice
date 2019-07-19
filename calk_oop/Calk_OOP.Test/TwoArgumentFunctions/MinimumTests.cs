using calk_oop.TwoArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.TwoArgumentFunctions
{
    [TestFixture]
    class MinimumCalculateTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(1, 4, 1)]
        [TestCase(25, 4, 4)]
        public void CalculateTest(double arOne, double arTwo, double expected)
        {
            var calculator = new Minimum();
            var actualResult = calculator.Calculate(arOne, arTwo);
            Assert.AreEqual(expected, actualResult);
        }
    }
}