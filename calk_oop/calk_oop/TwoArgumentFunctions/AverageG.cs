using System;
namespace calk_oop.TwoArgumentFunctions
{
    public class AverageG : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Sqrt(firstValue*secondValue);
        }
    }
}