using System;
namespace calk_oop.OneArgumentFunctions
{
    public class Mod : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {
            return Math.Abs(number);
        }
    }
}
 