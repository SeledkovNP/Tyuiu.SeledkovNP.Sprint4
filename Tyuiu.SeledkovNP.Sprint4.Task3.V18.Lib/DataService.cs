using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SeledkovNP.Sprint4.Task3.V18.Lib
{
    public class DataService : ISprint4Task3V18
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int max = array[4, 0];
            for (int j = 1; j < 5; j++)
            {
                if (array[4, j] > max)
                {
                    max = array[4, j];
                }
            }
            return max;
        }
    }
    
}
