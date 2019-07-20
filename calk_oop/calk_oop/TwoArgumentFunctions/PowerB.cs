using System;
namespace calk_oop.TwoArgumentFunctions
{
    /// <summary>
    /// Calculate x^(1/y)  where x - firstValue  y- secondValue
    /// </summary>
    /// <param name="firstValue"></param>
    /// <param name="secondValue"></param>
    /// <returns>Calculated number</returns>
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