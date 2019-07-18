using System;

namespace calk_oop.OneArgumentFunctions
{
    public class Divideback : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {
            return 1/number;
        }
    }
}