using calk_oop.OneArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.OneArgumentFunctions
{
    [TestFixture]
    class ModCalculateTests
    {
        [TestCase(0.1, 0.1)]
        [TestCase(-1, 1)]
        [TestCase(-0.5, 0.5)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Mod();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult);
        }
    }
}