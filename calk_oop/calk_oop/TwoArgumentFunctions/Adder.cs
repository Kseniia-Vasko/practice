namespace calk_oop.TwoArgumentFunctions
{
    public class Adder : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate sum for two numbers
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns>Calculated number</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
