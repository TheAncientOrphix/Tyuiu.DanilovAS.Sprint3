using System.Text.Json.Serialization.Metadata;
using Tyuiu.DanilovAS.Sprint3.Task5.V6.Lib;
namespace Tyuiu.DanilovAS.Sprint3.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Данилов А.С. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич | ИИПб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу решающую формулу с помощью вложенного     *");
            Console.WriteLine("* цикла.                                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValueOne = 1;
            int stopValueOne = 3;
            int startValueTwo = 1;
            int stopValueTwo = 10;
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSumSeries(startValueOne, startValueTwo, stopValueOne, stopValueTwo);
            Console.WriteLine($"Ответ равен => {res}");
            Console.ReadKey();
        }
    }
}
