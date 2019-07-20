using calk_oop.OneArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.OneArgumentFunctions
{
    [TestFixture]
    public class CosinusTests
    {

        [Test]
        public void CosinusTest()
        {

            Cosinus calculator = new Cosinus();
            double result = calculator.Calculate(0);
            Assert.AreEqual(1, result);
        }
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new Cosinus();
            Assert.Throws<System.Exception>(() => calculator.Calculate(-4));
        }

    }
}