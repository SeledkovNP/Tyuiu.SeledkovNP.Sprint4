using Tyuiu.SeledkovNP.Sprint4.Task2.V28.Lib;
namespace Tyuiu.SeledkovNP.Sprint4.Task2.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Селедков Н.П. | СМАРТБ-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема:  Одномерные массивы (генератор случайных чисель)                 *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #28                                                            *");
            Console.WriteLine("* Выполнил: Селедков Никита Павлович | СМАРТБ-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный        *");
            Console.WriteLine("* лучайными в диапазоне от 2 до 9 подсчитать сумму нечетных элементов    *");
            Console.WriteLine("* массива.                                                               *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Random ran = new Random();

            Console.WriteLine("Введите количество элементов в массиве");
            int len = Convert.ToInt32(Console.ReadLine());


            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = ran.Next(2, 8);
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Сумма нечётных элементов массива: ");
            Console.WriteLine(ds.Calculate(numsArray));

            Console.ReadKey();

        }
    }
}
