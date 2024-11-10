using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KorotkovNS.Sprint4.Task3.V14.Lib
{
    public class DataService : ISprint4Task3V14
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1; // кол-во строк
            int colms = array.Length / rows; // кол-во столбцов

            int chislo = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colms; j++)
                {
                    if ((j >= 0 && j <= 3) && i == 1)
                    {
                        if (array[i,j] > chislo)
                        {
                            chislo = array[i,j];
                        }
                    }
                }
            }
            return chislo;
        }
    }
}
