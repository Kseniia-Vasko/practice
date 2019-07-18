using System;
namespace calk_oop.OneArgumentFunctions
{
    public class Logarithm10 : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {
            return Math.Log10(number);
        }
    }
}