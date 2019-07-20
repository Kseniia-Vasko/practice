using System;

namespace calk_oop.OneArgumentFunctions
{
    public class Divideback : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {

            if (number == 0 )
            {
                throw new Exception("Нельзя делить на 0");
            }
            return 1/number;
        }
    }
}