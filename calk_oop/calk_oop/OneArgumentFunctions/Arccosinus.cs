﻿using System;

namespace calk_oop.OneArgumentFunctions
{

    public class Arccosinus : IOneArgumentsCalculator
    {
        /// <summary>
        /// Calculate arccosinus in radians from one argument
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Calculated number</returns>
        public double Calculate(double number)
        {

            if (number > 1 || number < -1)
            {
                throw new Exception("Значения должны быть от -1 до 1  включительно");
            }
            return Math.Acos(number);
        }
    }
}



