using Tyuiu.SeledkovNP.Sprint4.Task4.V20.Lib;
namespace Tyuiu.SeledkovNP.Sprint4.Task4.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Селедков Н.П. | СМАРТБ-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема:  Двумерные массивы (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #20                                                            *");
            Console.WriteLine("* Выполнил: Селедков Никита Павлович | СМАРТБ-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный       *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 8. Заменить четные элементы*");
            Console.WriteLine("* массива на 1.                                                          *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            /*
             4, 5, 5, 6, 4,

             7, 8, 4, 7, 5,

             5, 6, 5, 8, 5,

             7, 5, 8, 7, 8,

             4, 7, 7, 8, 8,
             */

            int[,] array = new int[5, 5];


            Console.WriteLine("Введите элементы двумерного массива (от 4 до 8):");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int value = 0;
                    bool isValid = false;


                    while (!isValid)
                    {
                        Console.Write($"[{i + 1},{j + 1}]: ");
                        isValid = int.TryParse(Console.ReadLine(), out value);

                        if (!isValid || value < 4 || value > 8)
                        {
                            Console.WriteLine("Некорректное значение!");
                            isValid = false;
                        }
                    }

                    array[i, j] = value;
                }
            }



            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        array[i, j] = 1;
                    }
                }
            }


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("\nИзмененный массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
                
            }

            Console.ReadKey();

        }
    }
}
