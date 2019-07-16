using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calk_oop
{
   public class Subrtacter : ITwoArgumentsCalcukator
    {
       public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
