using System;
namespace calk_oop.OneArgumentFunctions
{
    public class Cotangens : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {
            return (1/Math.Tan(number));
        }
    }
}