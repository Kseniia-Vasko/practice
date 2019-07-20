using System;
namespace calk_oop.OneArgumentFunctions
{
    public class Negation : IOneArgumentsCalculator
    {
        /// <summary>
        /// Calculate -x for one argument
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Calculated number</returns>
        public double Calculate(double number)
        {
            return -number;
        }
    }
}