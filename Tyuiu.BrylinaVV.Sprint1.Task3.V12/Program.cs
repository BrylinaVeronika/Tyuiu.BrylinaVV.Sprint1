using Tyuiu.BrylinaVV.Sprint1.Task3.V12.Lib;
namespace Tyuiu.BrylinaVV.Sprint1.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Брылина В. В. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Брылина Вероника Вячеславовна | ИИПб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
           
            DataService ds = new DataService();

            double a = 3;
            double b = 4;
            Console.WriteLine("Катет А треугольника = " + a);
            Console.WriteLine("Катет B треугольника = " + b);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Площадь прямоугольного треугольника = " + ds.TriangleArea(a, b));
            Console.ReadKey();

        }
    }
}
