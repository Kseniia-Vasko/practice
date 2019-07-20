namespace calk_oop.TwoArgumentFunctions
{
    public class Average : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate average number of two numbers
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns>Calculated number</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return ((firstValue + secondValue) / 2);
        }
    }
}