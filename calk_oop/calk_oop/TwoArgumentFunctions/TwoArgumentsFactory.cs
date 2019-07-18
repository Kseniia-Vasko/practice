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
                default:
                    throw new Exception("Unknown operation");
            }
        }
    }
}
