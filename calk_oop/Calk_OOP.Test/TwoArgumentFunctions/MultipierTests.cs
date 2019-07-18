using calk_oop.TwoArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.TwoArgumentFunctions
{
    [TestFixture]
    public class MultipierTests
    {

        [Test]
        public void MultipierTest()
        {

            Multipier calculator = new Multipier();
            double result = calculator.Calculate(6, 5);
            Assert.AreEqual(30, result);
        }


    }
}