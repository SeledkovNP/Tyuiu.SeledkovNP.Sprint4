using Tyuiu.SeledkovNP.Sprint4.Task3.V18.Lib;
namespace Tyuiu.SeledkovNP.Sprint4.Task3.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Селедков Н.П. | СМАРТБ-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема:  Двумерные массивы (статический ввод)                            *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #18                                                            *");
            Console.WriteLine("* Выполнил: Селедков Никита Павлович | СМАРТБ-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный       *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 9. Найдите максимальный    *");
            Console.WriteLine("* элемент в последней строке массива.                                    *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            /*
             2, 4, 2, 7, 7,

             4, 7, 9, 9, 7,

             8, 5, 5, 6, 5,

             7, 7, 5, 2, 9,

             9, 3, 7, 9, 8,
             */
            //                                    1                   2                     3                   4                    5
            int[,] array = new int[5, 5] {{ 2, 4, 2, 7, 7 },  { 4, 7, 9, 9, 7 },   { 8, 5, 5, 6, 5 },  { 7, 7, 5, 2, 9 },  { 9, 3, 7, 9, 8 } };


            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            Console.WriteLine("Массив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine("Максимальный элемент в последней строке массива: " + res);

            Console.ReadKey();

        }
    }
}
