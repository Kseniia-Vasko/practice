using System;

namespace calk_oop.OneArgumentFunctions
{
    public class Pow10 : IOneArgumentsCalculator
    {
        /// <summary>
        /// Calculate 10^x for one argument
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Calculated number</returns>
        public double Calculate(double number)
        {
            return Math.Pow(10, number);
        }
    }
}