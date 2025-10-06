using System.Text.Json.Serialization.Metadata;
using Tyuiu.DanilovAS.Sprint3.Task7.V24.Lib;
namespace Tyuiu.DanilovAS.Sprint3.Task7.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Данилов А.С. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич | ИИПб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = sin(x)/(x+1.2) - sin(x) *2 - 2*x на заданном диапазоне [-5; 5]   *");
            Console.WriteLine("* с шагом 1. Произвести проверку деления на ноль. При деление на ноль     *");
            Console.WriteLine("* вернуть значение 0. Значение округлить до двух знаков после запятой     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] res;
            res = new double[len];

            res = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     | {1,5:f2} |", startValue, res[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();


        }
    }
}
