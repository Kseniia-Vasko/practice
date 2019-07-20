using System;
namespace calk_oop.OneArgumentFunctions
{
    public class Cotangens : IOneArgumentsCalculator
    { /// <summary>
      /// Calculate cotangens in radians from one argument
      /// </summary>
      /// <param name="number"></param>
      /// <returns>Calculated number</returns>
        public double Calculate(double number)
        {
            return (1 / Math.Tan(number));
        }
    }
}