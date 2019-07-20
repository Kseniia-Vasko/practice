using System;

namespace calk_oop.OneArgumentFunctions
{
    public class Divideback : IOneArgumentsCalculator
    { /// <summary>
      /// Calculate function 1/x for one argument
      /// </summary>
      /// <param name="number"></param>
      /// <returns>Calculated number</returns>
        public double Calculate(double number)
        {

            if (number == 0)
            {
                throw new Exception("Нельзя делить на 0");
            }
            return 1 / number;
        }
    }
}