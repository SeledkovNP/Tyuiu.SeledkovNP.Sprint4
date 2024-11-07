using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SeledkovNP.Sprint4.Task0.V6.Lib
{
    public class DataService : ISprint4Task0V6
    {
        public int GetSumOddArrEl(int[] array)
        {

            int res = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    res += array[i];
                }
            }
            return res;

        }
    }
}
