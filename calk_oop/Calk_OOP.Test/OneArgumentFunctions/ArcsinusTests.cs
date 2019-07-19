using calk_oop.OneArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.OneArgumentFunctions
{
    [TestFixture]
    class ArcsinusCalculateTests
    {
        [TestCase(0.1, 0.100)]
        [TestCase(1, 1.570 )]
        [TestCase(0.5, 0.523)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Arcsinus();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}