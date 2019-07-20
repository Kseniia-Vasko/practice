using System;

namespace calk_oop.OneArgumentFunctions
{
    public class Sinus : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {

            if (number > 1 || number < -1)
            {
                throw new Exception("Значения должны быть от -1 до 1 включительно");
            }
            return Math.Sin(number);
        }
    }
}
