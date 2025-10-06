using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DanilovAS.Sprint3.Task6.V22.Lib
{
    public class DataService : ISprint3Task6V22
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for(int d = 1; d <= i; d++)
                {
                    if (i%d == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
