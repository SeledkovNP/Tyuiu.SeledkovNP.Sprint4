using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SeledkovNP.Sprint4.Task2.V28.Lib
{
    public class DataService : ISprint4Task2V28
    {
        public int Calculate(int[] array)
        {

            int sumArray = 0;
            foreach (int i in array)
            {
                if (i % 2 != 0)
                {
                    sumArray += i;
                }
            }
            return sumArray;
        }

    }
    
}
