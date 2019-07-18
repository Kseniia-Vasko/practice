namespace calk_oop.TwoArgumentFunctions
{
    public class Average : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return ((firstValue + secondValue)/2);
        }
    }
}