using System;
namespace calk_oop.OneArgumentFunctions
{
    public class Negation : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {
            return -number;
        }
    }
}