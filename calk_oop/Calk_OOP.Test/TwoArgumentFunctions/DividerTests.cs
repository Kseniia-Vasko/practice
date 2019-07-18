using calk_oop.TwoArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.TwoArgumentFunctions
{
    [TestFixture]
    public class DividerTests
    {

        [Test]
        public void DividerTest()
        {

            Divider calculator = new Divider();
            double result = calculator.Calculate(6, 3);
            Assert.AreEqual(2, result);
        }


    }
}