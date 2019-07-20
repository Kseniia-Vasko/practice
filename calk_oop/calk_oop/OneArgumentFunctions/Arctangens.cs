using System;
namespace calk_oop.OneArgumentFunctions
{
    public class Arctangens : IOneArgumentsCalculator
    {
        /// <summary>
        /// Calculate arctangens in radians from one argument
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Calculated number</returns>
        public double Calculate(double number)
        {
            return Math.Atan(number);
        }
    }
}
