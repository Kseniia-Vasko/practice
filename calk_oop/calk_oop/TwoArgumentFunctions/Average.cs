namespace calk_oop.TwoArgumentFunctions
{
    public class Average : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate average number of two numbers
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Calculated number</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return ((firstValue + secondValue)/2);
        }
    }
}