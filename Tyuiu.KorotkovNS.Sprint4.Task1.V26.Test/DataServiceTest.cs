using Tyuiu.KorotkovNS.Sprint4.Task1.V26.Lib;
namespace Tyuiu.KorotkovNS.Sprint4.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds =new DataService();

            int[] numsArray = { 7, 7, 8, 8, 2, 6, 3, 3, 3, 1 };
            int res = ds.Calculate(numsArray);
            int wait = 24;
            Assert.AreEqual(wait, res);
        }
    }
}