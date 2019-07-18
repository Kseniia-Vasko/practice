using System;
namespace calk_oop.OneArgumentFunctions
{
    public class Tangens : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {
            return Math.Tan(number);
        }
    }
}