using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SeledkovNP.Sprint4.Task7.V8.Lib
{
    public class DataService : ISprint4Task7V8
    {
        public int Calculate(int n, int m, string value)
        {

            int[,] mtrx = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] % 2 != 0)
                    {
                        s += mtrx[i, j];
                    }
                }
            }
            return s;

        }
    }
}
