using calk_oop.TwoArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.TwoArgumentFunctions
{
    [TestFixture]
    class MaximumCalculateTests
    {
        [TestCase(4, 2, 4)]
        [TestCase(1, 4, 4)]
        [TestCase(25, 4, 25)]
        public void CalculateTest(double arOne, double arTwo, double expected)
        {
            var calculator = new Maximum();
            var actualResult = calculator.Calculate(arOne, arTwo);
            Assert.AreEqual(expected, actualResult);
        }
    }
}