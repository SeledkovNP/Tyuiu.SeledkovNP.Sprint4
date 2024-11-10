using Tyuiu.SeledkovNP.Sprint4.Task6.V20.Lib;
namespace Tyuiu.SeledkovNP.Sprint4.Task6.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Селедков Н.П. | СМАРТБ-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема:  Двумерные массивы (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #20                                                            *");
            Console.WriteLine("* Выполнил: Селедков Никита Павлович | СМАРТБ-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан строковый массив данных [\"Математика\", \"Физика\", \"Химия\",    *");
            Console.WriteLine("* \"Биология\", \"География\", \"История\", \"Литература\"], используя   *");
            Console.WriteLine("* класс Array, выведите элементы массива, длина которых меньше 10        *");
            Console.WriteLine("* символов                                                               *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            string[] mas = { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= mas.Length - 1; i++)
            {
                Console.WriteLine(mas[i]);
            }



            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            string[] res = ds.Calculate(mas);
            for (int i = 0; i < res.GetLength(0); i++)
            {
                Console.WriteLine(res[i]);

            }


            Console.ReadKey();

        }
    }
}
