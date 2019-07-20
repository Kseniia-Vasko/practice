using System;

namespace calk_oop.TwoArgumentFunctions
{
    public class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string name)
        {
            switch (name)
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
                case "Min":
                    return new Minimum();
                case "Max":
                    return new Maximum();
                case "Avg":
                    return new Average();
                case "GeomAvg":
                    return new AverageGeometric();
                default:
                    throw new Exception("Unknown operation");
            }
        }
    }
}
