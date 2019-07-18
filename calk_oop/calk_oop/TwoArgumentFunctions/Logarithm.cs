using System;
namespace calk_oop.TwoArgumentFunctions
{
    public class Logarithm : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Log(firstValue, secondValue);
        }
    }
}
   