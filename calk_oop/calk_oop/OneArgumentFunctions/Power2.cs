using System;

namespace calk_oop.OneArgumentFunctions
{
    public class Power2 : IOneArgumentsCalculator
    {
        /// <summary>
        /// Calculate 2^x for one argument
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Calculated number</returns>
        public double Calculate(double number)
        {
            return Math.Pow(2, number);
        }
    }
}