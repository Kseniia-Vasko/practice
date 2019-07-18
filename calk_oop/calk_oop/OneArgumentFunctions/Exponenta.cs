using System;

namespace calk_oop.OneArgumentFunctions
{
    public class Exponenta : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {
            return Math.Exp(number);
        }
    }
}
