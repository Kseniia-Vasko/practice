using System;
namespace calk_oop.OneArgumentFunctions
{
    public class Powertwo : IOneArgumentsCalculator
    {
        /// <summary>
        /// Calculate x^2 for one argument
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Calculated number</returns>
        public double Calculate(double number)
        {
            return Math.Pow(number, 2);
        }
    }
}