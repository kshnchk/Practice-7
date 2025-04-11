/*
Дана матрица N x M. Найти строку, сумма элементов которой
максимальна, сохранить её как одномерный массив и вывести на экран.
*/

namespace задание_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 4; 
            int cols = 5; 
            int[,] matrix = new int[rows, cols];
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(1, 101);
                }
            }
            Console.WriteLine("Сгенерированная матрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int maxSumIndex = 0;
            int maxSum = 0;

            for (int i = 0; i < rows; i++)
            {
                int currentSum = 0;
                for (int j = 0; j < cols; j++)
                {
                    currentSum += matrix[i, j];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSumIndex = i;
                }
            }
            int[] maxSumRow = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                maxSumRow[j] = matrix[maxSumIndex, j];
            }
            Console.WriteLine("\nСтрока с максимальной суммой элементов:");
            Console.WriteLine(string.Join(", ", maxSumRow));
        }
    }
}
