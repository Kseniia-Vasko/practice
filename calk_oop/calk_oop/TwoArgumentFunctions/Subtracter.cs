using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calk_oop.TwoArgumentFunctions
{
   public class Subtracter : ITwoArgumentsCalculator
    {
       public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
