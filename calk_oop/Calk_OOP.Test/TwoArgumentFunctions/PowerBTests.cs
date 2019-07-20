using calk_oop.TwoArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.TwoArgumentFunctions
{
    [TestFixture]
    class PowerBCalculateTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(1, 4, 1)]
        [TestCase(25,2  , 5)]
        public void CalculateTest(double arOne, double arTwo, double expected)
        {
            var calculator = new PowerB();
            var actualResult = calculator.Calculate(arOne, arTwo);
            Assert.AreEqual(expected, actualResult);
        }
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new PowerB();
            Assert.Throws<System.Exception>(() => calculator.Calculate(1,0));
        }
    }
}