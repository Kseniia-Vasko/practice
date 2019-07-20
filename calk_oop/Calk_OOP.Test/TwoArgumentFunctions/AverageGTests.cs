using calk_oop.TwoArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.TwoArgumentFunctions
{
    [TestFixture]
    class AverageGCalculateTests
    {
        [TestCase(2, 2, 2)]
        [TestCase(4, 4, 4)]
        [TestCase(25, 4, 10)]
        public void CalculateTest(double arOne, double arTwo, double expected)
        {
            var calculator = new AverageGeometric();
            var actualResult = calculator.Calculate(arOne, arTwo);
            Assert.AreEqual(expected, actualResult);
        }
    }
}