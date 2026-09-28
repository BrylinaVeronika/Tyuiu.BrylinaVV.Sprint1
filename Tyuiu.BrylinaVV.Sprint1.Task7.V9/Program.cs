using Tyuiu.BrylinaVV.Sprint1.Task7.V9.Lib;
namespace Tyuiu.BrylinaVV.Sprint1.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Брылина В. В. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила: Брылина Вероника Вячеславовна | ИИПб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
            Console.WriteLine("*            2      3           2                                         *");
            Console.WriteLine("*       x   y + cosx + 12xy - 3x                                          *");
            Console.WriteLine("*  z = e - ------------------------                                       *");
            Console.WriteLine("*                3                                                        *");
            Console.WriteLine("*           cos(x + 3) + 18xy - 1                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение х : ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y : ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double z = ds.Calculate(x, y);
            Console.WriteLine(z);

        }
    }
}
