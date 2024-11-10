using Tyuiu.SeledkovNP.Sprint4.Task6.V20.Lib;
namespace Tyuiu.SeledkovNP.Sprint4.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            string[] mas = { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };
            string[] wait = { "Физика", "Химия", "Биология", "География", "История" };
            string[] res = ds.Calculate(mas);
            CollectionAssert.AreEqual(wait, res);

        }
    }
}