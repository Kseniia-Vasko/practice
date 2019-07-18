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
                default:
                    throw new Exception("Unknown operation");
            }
        }
    }
}
