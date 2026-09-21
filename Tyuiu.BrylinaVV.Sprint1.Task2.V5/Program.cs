using Tyuiu.BrylinaVV.Sprint1.Task2.V5.Lib;
namespace Tyuiu.BrylinaVV.Sprint1.Task2.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Брылина В. В. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Брылина Вероника Вячеславовна | ИИПб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите длину стороны куба:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Console.WriteLine("Площадь поверхности куба = " + ds.CalculateSideSquare(x));

        }
    }
}
