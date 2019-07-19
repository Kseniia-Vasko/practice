using calk_oop.OneArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.OneArgumentFunctions
{
    [TestFixture]
    class TangensCalculateTests
    {
        [TestCase(1, 1.557)]
        [TestCase(10, 0.648)]
        [TestCase(2,-2.185)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Tangens();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}