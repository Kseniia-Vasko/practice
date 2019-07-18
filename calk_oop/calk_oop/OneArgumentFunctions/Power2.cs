using System;

namespace calk_oop.OneArgumentFunctions
{
    public class Power2 : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {
            return Math.Pow(2, number);
        }
    }
}