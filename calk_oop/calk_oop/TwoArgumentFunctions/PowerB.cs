using System;
namespace calk_oop.TwoArgumentFunctions
{
    public class PowerB : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("Нельзя делить на 0");
            }
            return Math.Pow(firstValue, (1/secondValue));
        }
    }
}