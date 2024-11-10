using Tyuiu.KorotkovNS.Sprint4.Task2.V7.Lib;
namespace Tyuiu.KorotkovNS.Sprint4.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 4, 4, 5, 6, 7, 7, 7, 4, 5, 9, 5 };

            int res = ds.Calculate(numsArray);
            int wait = 22;

            Assert.AreEqual(wait, res);
        }
    }
}