using System;

namespace calk_oop.OneArgumentFunctions
{
    public class Pow10 : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {
            return Math.Pow(10, number);
        }
    }
}