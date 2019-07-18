using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calk_oop.OneArgumentFunctions
{
   public class Cosinus : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {
            return Math.Cos(number);
        }
    }
}
