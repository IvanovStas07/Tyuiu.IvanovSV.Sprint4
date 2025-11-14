// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using Tyuiu.IvanovSV.Sprint4.Task1.V26.Lib;
namespace Tyuiu.IvanovSV.Sprint4.Task1.V26
{
    class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Иванов С. В. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнила: Иванов С. В. | ИСТНб-25-1                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
        Console.WriteLine("* статическими значениями в диапазоне от 0 до 8 подсчитать сумму          *");
        Console.WriteLine("* нечетных элементов массиваС клавиатуры: 7, 7, 8, 8, 2, 6, 3, 3, 3, 1    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int len;
        Console.Write("Введите кол-во элементов массива: ");
        len = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[len];

        for (int i = 0; i < len; i++)
        {
            Console.WriteLine("Введите значение " + i + " элемента массива: ");
            int z = Convert.ToInt32(Console.ReadLine());
            if (-1 < z && z <9)
                {
                    array[i] = z;
                }
                else
                {
                    Console.WriteLine("вне диапазона");
                    Thread.Sleep(2000);
                    return;
                }
            // array[i] = Convert.ToInt32(Console.ReadLine());
            }
        Console.WriteLine();
        Console.WriteLine("Массив: ");
        for (int i = 0; i < len; i++)
        {
            Console.WriteLine(array[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(array);

        Console.WriteLine(res);
        Console.ReadKey();
    }
}
}