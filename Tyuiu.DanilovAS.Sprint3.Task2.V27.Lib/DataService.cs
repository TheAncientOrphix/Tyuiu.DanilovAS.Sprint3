using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DanilovAS.Sprint3.Task2.V27.Lib
{
    public class DataService : ISprint3Task2V27
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double res = 0;
            do
            {
                res += Math.Pow(4/(1+Math.Pow(value,startValue)),startValue);
                startValue++;
            }while (startValue<=stopValue);

            return Math.Round(res, 3);
        }
    }
}
