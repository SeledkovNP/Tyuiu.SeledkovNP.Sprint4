using Tyuiu.SeledkovNP.Sprint4.Task1.V21.Lib;
namespace Tyuiu.SeledkovNP.Sprint4.Task1.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Селедков Н.П. | СМАРТБ-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема:  Одномерные массивы (ввод с клавиатуры)                          *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #21                                                            *");
            Console.WriteLine("* Выполнил: Селедков Никита Павлович | СМАРТБ-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 8 подсчитать произведение  *");
            Console.WriteLine("* четных элементов массива. С клавиатуры: 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6*");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            /// 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6

            int[] arrayNums = new int[11];

            for (int i = 0; i < arrayNums.Length; i++)
            {
                Console.Write("Введите занчение " + i + " элемента массива: ");
                arrayNums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            Console.Write("Массив: { ");
            for (int i = 0; i < arrayNums.Length; i++)
            {
                Console.Write(arrayNums[i] + " ");
            }
            Console.WriteLine(" }");
            Console.WriteLine();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Произведение четных элементов = " + ds.Calculate(arrayNums));

            Console.ReadKey();

        }
    }
}
