using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SeledkovNP.Sprint4.Task6.V20.Lib
{
    public class DataService : ISprint4Task6V20
    {
        public string[] Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, i => i.Length < 10);
            return mas;
        }
    }
}
