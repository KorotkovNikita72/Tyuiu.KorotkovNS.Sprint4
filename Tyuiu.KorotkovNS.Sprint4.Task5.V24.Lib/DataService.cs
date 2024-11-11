using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KorotkovNS.Sprint4.Task5.V24.Lib
{
    public class DataService : ISprint4Task5V24
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colms = matrix.Length / rows;

            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colms; j++)
                {
                    if (matrix[i, j] > 0)
                    {

                        count++;
                    }
                }
            }
            return count;
        }
    }
}
