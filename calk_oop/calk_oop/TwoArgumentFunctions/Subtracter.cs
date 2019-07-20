namespace calk_oop.TwoArgumentFunctions
{
    /// <summary>
    /// Subtract firstValue from secondValue
    /// </summary>
    /// <param name="number"></param>
    /// <returns>Calculated number</returns>
    public class Subtracter : ITwoArgumentsCalculator
    {
       public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
