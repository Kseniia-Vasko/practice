using System;
namespace calk_oop.TwoArgumentFunctions
{
    public class Maximum : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Max(firstValue, secondValue);
        }
    }
}