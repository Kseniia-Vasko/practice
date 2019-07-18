using  System;
namespace calk_oop.TwoArgumentFunctions
{
    public class Power : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, secondValue);
        }
    }
}