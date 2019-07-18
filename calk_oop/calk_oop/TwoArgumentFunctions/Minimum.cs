using System;
namespace calk_oop.TwoArgumentFunctions
{
    public class Minimum : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Min(firstValue, secondValue);
        }
    }
}
 