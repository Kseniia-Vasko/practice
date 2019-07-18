using calk_oop.TwoArgumentFunctions;
using NUnit.Framework;

namespace Calk_OOP.Test.TwoArgumentFunctions
{
    [TestFixture]
    public  class AdderTests
    {

        [Test]
        public void AdderTest()
        {
            
            Adder calculator= new Adder();
            double result = calculator.Calculate(2, 5);
            Assert.AreEqual(7, result);
        }


    }
}