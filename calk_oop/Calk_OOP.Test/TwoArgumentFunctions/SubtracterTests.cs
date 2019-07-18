using calk_oop.TwoArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.TwoArgumentFunctions
{
    [TestFixture]
    public class SubtracterTests
    {

        [Test]
        public void SubtracterTest()
        {

            Subtracter calculator = new Subtracter();
            double result = calculator.Calculate(6, 5);
            Assert.AreEqual(1, result);
        }


    }
}