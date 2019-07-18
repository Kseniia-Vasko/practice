using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                default:
                    throw new Exception("Unknown operation");
            }
        }
    }
}
