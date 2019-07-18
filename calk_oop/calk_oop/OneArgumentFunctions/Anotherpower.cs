using System;
namespace calk_oop.OneArgumentFunctions
{
    public class Anotherpower : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {
            return Math.Pow(number, 2);
        }
    }
}