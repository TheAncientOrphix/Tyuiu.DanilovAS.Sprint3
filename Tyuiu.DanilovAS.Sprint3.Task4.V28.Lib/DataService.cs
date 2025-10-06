using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DanilovAS.Sprint3.Task4.V28.Lib
{
    public class DataService : ISprint3Task4V28
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            int i;
            int x = 0;
            for (i = startValue; i<=stopValue;i++)
            {
                if (i == 0)
                {
                    continue;
                }
                res += Math.Cos(i) + Math.Sin(i) / (4.0);
            }
            return Math.Round(res, 3);
        }
    }
}
