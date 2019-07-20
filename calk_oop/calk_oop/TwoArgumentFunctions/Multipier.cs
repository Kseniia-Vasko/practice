namespace calk_oop.TwoArgumentFunctions
{
    /// <summary>
    /// Multiply two numbers
    /// </summary>
    /// <param name="number"></param>
    /// <returns>Calculated number</returns>
    public class Multipier : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
}
