using System;

namespace calk_oop.OneArgumentFunctions
{
   public class OneArgumentsFactory
    {
        public static IOneArgumentsCalculator CreateCalculator(string Name)
        {
            switch (Name)
            {
                case "Sin":
                    return new Sinus();
                case "Cos":
                    return new Cosinus();
                case "Exp":
                    return new Exponenta();
                case "Tan":
                    return new Tangens();
                case "Arcsin":
                    return new Arcsinus();
                case "Arccos":
                    return new Arccosinus();
                case "Arctan":
                    return new Arctangens();
                case "Abs":
                    return new Mod();
                case "Ln":
                    return new LogarithmN();
                case "Lg":
                    return new Logarithm10();
                default:
                    throw new Exception("Unknown operation");
            }
        }
    }
}
