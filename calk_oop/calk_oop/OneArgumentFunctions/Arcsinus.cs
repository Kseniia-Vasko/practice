using System;
namespace calk_oop.OneArgumentFunctions
{
    public class Arcsinus : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {
            return Math.Asin(number);
        }
    }
}