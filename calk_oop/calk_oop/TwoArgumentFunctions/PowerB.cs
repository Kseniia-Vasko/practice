using System;
namespace calk_oop.TwoArgumentFunctions
{
    public class PowerB : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, (1/secondValue));
        }
    }
}