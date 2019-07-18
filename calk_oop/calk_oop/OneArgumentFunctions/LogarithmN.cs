using System;
namespace calk_oop.OneArgumentFunctions
{
    public class LogarithmN : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {
            return Math.Log(number);
        }
    }
}
   