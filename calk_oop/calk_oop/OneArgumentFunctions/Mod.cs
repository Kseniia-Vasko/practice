using System;
namespace calk_oop.OneArgumentFunctions
{
    public class Mod : IOneArgumentsCalculator
    {
        /// <summary>
        /// Calculate |x| for one argument
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Calculated number</returns>
        public double Calculate(double number)
        {
            return Math.Abs(number);
        }
    }
}
