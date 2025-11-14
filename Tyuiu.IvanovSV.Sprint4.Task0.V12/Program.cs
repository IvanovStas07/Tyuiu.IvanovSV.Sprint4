using Tyuiu.IvanovSV.Sprint4.Task0.V12.Lib;
namespace Tyuiu.IvanovSV.Sprint4.Task0.V12
{
    internal class Program
{
    static void Main(string[] args)
    {
        int res;
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил Иванов С. В. | ИСТНб-25-1";
        Console.WriteLine("*******************************************************************************");
        Console.WriteLine("* Спринт #4                                                                   *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                            *");
        Console.WriteLine("* Задание #0                                                                  *");
        Console.WriteLine("* Вариант #12                                                                 *");
        Console.WriteLine("* Выполнил Иванов С В | ИСТНю-25-1                           *");
        Console.WriteLine("*******************************************************************************");
        Console.WriteLine("* Условие                                                                     *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный             *");
        Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение       *");
        Console.WriteLine("* четных элементов массива.                                                   *");
        Console.WriteLine("*******************************************************************************");
        Console.WriteLine("* Исходные данные:                                                            *");
        Console.WriteLine("*******************************************************************************");
        int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
        Console.WriteLine("* Результат:                                                                  *");
        Console.WriteLine("*******************************************************************************");
        res = ds.GetMultEvenArrEl(array);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}
}