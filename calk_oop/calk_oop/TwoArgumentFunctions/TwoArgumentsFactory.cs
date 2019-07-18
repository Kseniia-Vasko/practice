using System;

namespace calk_oop.TwoArgumentFunctions
{
    public class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string Name)
        {
            switch (Name)
            {
                case "Add":
                    return new Adder();
                case "Subtraction":
                   return new Subtracter();
                case "Multiplication":
                   return new Multipier();
                case "Divide":
                    return new Divider();
                case "Pow":
                    return new Power();
                case "Power":
                    return new PowerB();
                case "Log":
                    return new Logarithm();
                default:
                    throw new Exception("Unknown operation");
            }
        }
    }
}
