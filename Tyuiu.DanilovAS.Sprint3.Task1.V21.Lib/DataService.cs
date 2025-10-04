using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DanilovAS.Sprint3.Task1.V21.Lib
{
    public class DataService : ISprint3Task1V21
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;

            while (startValue < stopValue)
            {
                p = Math.Pow(0.5 + (value / (5)) / (Math.Cos(value) + 0.5),3);
                startValue++;
            }

            return Math.Round(p, 3);
        }
    }
}
