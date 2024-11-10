using Tyuiu.SeledkovNP.Sprint4.Task7.V8.Lib;
namespace Tyuiu.SeledkovNP.Sprint4.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Селедков Н.П. | СМАРТБ-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту               *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #8                                                             *");
            Console.WriteLine("* Выполнил: Селедков Никита Павлович | СМАРТБ-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"264795863157\". Преобразуйте ее в  *");
            Console.WriteLine("* матрицу 3 на 4 и подсчитайте сумму нечетных чисел.                     *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int rows = 3;
            int coluns = 4;
            int[,] mtrx = new int[rows, coluns];
            string str = "264795863157";

            int index = 0;
            Console.WriteLine("\nMассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coluns; j++)
                {
                    Console.WriteLine($"{str[index]}\t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Сумма нечётных элементов матрицы = " + ds.Calculate(rows, coluns, str));
            Console.ReadKey();

        }
    }
}
