using System;
namespace calk_oop.TwoArgumentFunctions
{
    public class Logarithm : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate logarithm and you can choose argument(first value) and basis(second value)
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Calculated number</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            if (firstValue < 0 && (secondValue < 0 || secondValue == 1))
            {
                throw new Exception("Введите корректные значения");
            }
            return Math.Log(firstValue, secondValue);
        }
    }
}
   