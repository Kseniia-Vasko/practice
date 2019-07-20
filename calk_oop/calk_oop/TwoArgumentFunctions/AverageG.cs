using System;
namespace calk_oop.TwoArgumentFunctions
{
    public class AverageG : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate average geometric number of two numbers
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Calculated number</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Sqrt(firstValue*secondValue);
        }
    }
}