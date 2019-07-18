using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                default:
                    throw new Exception("Unknown operation");
            }
        }
    }
}
