﻿using  System;
namespace calk_oop.TwoArgumentFunctions
{
    /// <summary>
    /// Calculate x^y where x - firstValue  y- secondValue
    /// </summary>
    /// <param name="number"></param>
    /// <returns>Calculated number</returns>
    public class Power : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, secondValue);
        }
    }
}