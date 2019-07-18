using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calk_oop.OneArgumentFunctions
{
    public class Sinus : IOneArgumentsCalculator
    {
        public double Calculate(double number)
        {
            return Math.Sin(number);
        }
    }
}
