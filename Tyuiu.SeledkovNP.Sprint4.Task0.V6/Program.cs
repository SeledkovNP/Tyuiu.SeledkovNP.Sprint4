using Tyuiu.SeledkovNP.Sprint4.Task0.V6.Lib;
namespace Tyuiu.SeledkovNP.Sprint4.Task0.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Селедков Н.П. | СМАРТБ-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема:  Одномерные массивы (статический ввод)                           *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнил: Селедков Никита Павлович | СМАРТБ-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать               *");
            Console.WriteLine("* сумму нечетных элементов массива.                                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int[] array = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Сумма нечетных элементов =  " + ds.GetSumOddArrEl(array));
            Console.ReadKey();

        }
    }
}
