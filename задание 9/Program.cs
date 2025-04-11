/*
Составить программу обмена местами максимального и минимального
элементов главной диагонали матрицы.
*/

namespace задание_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 4;
            int[,] matrix = new int[size, size];
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rand.Next(1, 101);
                }
            }
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int minIndex = 0;
            int maxIndex = 0;
            int minValue = matrix[0, 0];
            int maxValue = matrix[0, 0];

            for (int i = 0; i < size; i++)
            {
                if (matrix[i, i] < minValue)
                {
                    minValue = matrix[i, i];
                    minIndex = i;
                }
                if (matrix[i, i] > maxValue)
                {
                    maxValue = matrix[i, i];
                    maxIndex = i;
                }
            }

            matrix[minIndex, minIndex] = maxValue;
            matrix[maxIndex, maxIndex] = minValue;

            Console.WriteLine("\nМатрица после обмена местами максимального и минимального элементов главной диагонали:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
