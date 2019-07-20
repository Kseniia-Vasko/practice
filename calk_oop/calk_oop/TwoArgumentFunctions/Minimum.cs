using System;
namespace calk_oop.TwoArgumentFunctions
{
    /// <summary>
    /// Compare two numbers and decide which one is smaller
    /// </summary>
    /// <param name="firstValue"></param>
    /// <param name="secondValue"></param>
    /// <returns>Calculated number</returns>
    public class Minimum : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Min(firstValue, secondValue);
        }
    }
}
 