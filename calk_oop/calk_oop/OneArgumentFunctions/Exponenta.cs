using System;

namespace calk_oop.OneArgumentFunctions
{
    public class Exponenta : IOneArgumentsCalculator
    {/// <summary>
     /// Calculate function exponent for one argument
     /// </summary>
     /// <param name="number"></param>
     /// <returns>Calculated number</returns>
        public double Calculate(double number)
        {
            return Math.Exp(number);
        }
    }
}
