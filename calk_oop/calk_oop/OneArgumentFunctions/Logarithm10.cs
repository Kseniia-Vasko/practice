using System;
namespace calk_oop.OneArgumentFunctions
{
    public class Logarithm10 : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {

            if (number < 0)
            {
                throw new Exception("Значение должно быть больше 0");
            }
            return Math.Log10(number);
        }
    }
}