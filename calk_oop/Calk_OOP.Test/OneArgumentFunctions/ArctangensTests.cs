using calk_oop.OneArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.OneArgumentFunctions
{
    [TestFixture]
    class ArctangensCalculateTests
    {
        [TestCase(0.1, 0.099)]
        [TestCase(1, 0.785)]
        [TestCase(0.5, 0.463)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Arctangens();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}