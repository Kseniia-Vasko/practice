using System;

namespace calk_oop.OneArgumentFunctions
{
   public class Cosinus : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {
            return Math.Cos(number);
        }
    }
}
