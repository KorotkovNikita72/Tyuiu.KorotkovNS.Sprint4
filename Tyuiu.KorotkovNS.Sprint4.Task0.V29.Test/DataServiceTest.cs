using Tyuiu.KorotkovNS.Sprint4.Task0.V29.Lib;
namespace Tyuiu.KorotkovNS.Sprint4.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int[] numsArray = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int res = ds.GetSumOddArrEl(numsArray);
            int numsWaitArray = 32;

            Assert.AreEqual(numsWaitArray, res);
        }
    }
}