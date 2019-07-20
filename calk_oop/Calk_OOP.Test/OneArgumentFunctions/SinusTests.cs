using calk_oop.OneArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.OneArgumentFunctions
{
    [TestFixture]
    public class SinusTests
    {

        [Test]
        public void SinusTest()
        {

            Sinus calculator = new Sinus();
            double result = calculator.Calculate(0);
            Assert.AreEqual(0, result);
        }
        
    }
}