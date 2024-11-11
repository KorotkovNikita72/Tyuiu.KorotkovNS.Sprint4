using Tyuiu.KorotkovNS.Sprint4.Task6.V24.Lib;
namespace Tyuiu.KorotkovNS.Sprint4.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string[] array = { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };
            string[] res = { "Компьютер", "Клавиатура" };

            CollectionAssert.AreEqual(res, ds.Calculate(array));
        }
    }
}