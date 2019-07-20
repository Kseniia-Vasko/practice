using System;

namespace calk_oop.OneArgumentFunctions
{
    public class OneArgumentsFactory
    {
        public static IOneArgumentsCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "Sin":
                    return new Sinus();
                case "Cos":
                    return new Cosinus();
                case "Exp":
                    return new Exponent();
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
                case "Neg":
                    return new Negation();
                case "Pw":
                    return new Power2();
                case "Pwr":
                    return new Pow10();
                case "Back":
                    return new Divideback();
                case "Pwer":
                    return new Powertwo();
                case "Ctg":
                    return new Cotangens();
                default:
                    throw new Exception("Unknown operation");
            }
        }
    }
}
