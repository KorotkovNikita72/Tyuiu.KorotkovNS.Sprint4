using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KorotkovNS.Sprint4.Task6.V24.Lib
{
    public class DataService : ISprint4Task6V24
    {
        public string[] Calculate(string[] array)
        {
            int count = array.Count(x => x.Length > 7);

            string[] res = new string[count];
            int i = 0;
            foreach (var item in array)
            {
                if (item.Length > 7)
                {
                    res[i++] = item;
                }
            }
            return res;
            
        }
    }
}
