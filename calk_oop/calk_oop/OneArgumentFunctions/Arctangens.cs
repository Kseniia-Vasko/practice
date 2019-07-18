using System;
namespace calk_oop.OneArgumentFunctions
{
    public class Arctangens : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {
            return Math.Atan(number);
        }
    }
}
   