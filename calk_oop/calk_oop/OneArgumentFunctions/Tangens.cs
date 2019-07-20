using System;
namespace calk_oop.OneArgumentFunctions
{
    public class Tangens : IOneArgumentsCalculator
    {
        /// <summary>
        /// Calculate tg for one argument in radians
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Calculated number</returns>
        public double Calculate(double number)
        {
            return Math.Tan(number);
        }
    }
}