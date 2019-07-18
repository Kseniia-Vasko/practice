using System;

namespace calk_oop.OneArgumentFunctions
{
    public class Sinus : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {
            return Math.Sin(number);
        }
    }
}
