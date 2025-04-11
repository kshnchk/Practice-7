/*
Вывести на экран матрицу 4x6. Найти сумму элементов каждой строки.
Вывести результат в виде одномерного массива и найти его максимальный
элемент.

(Вместо задания 7 было выполнено задание 8, так как первое некорректно отображалось 
в учебнике и являлось нечитаемым)
*/

namespace задание_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 4;
            int cols = 6;
            int[,] array = new int[rows, cols];
            int[] rowSums = new int[rows];
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rand.Next(1, 11);
                }
            }
            Console.WriteLine("Сгенерированная матрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    sum += array[i, j];
                }
                rowSums[i] = sum;
            }
            Console.WriteLine("Суммы элементов каждой строки:");
            Console.WriteLine(string.Join(", ", rowSums));
            int maxSum = rowSums[0];
            for (int i = 1; i < rowSums.Length; i++)
            {
                if (rowSums[i] > maxSum)
                {
                    maxSum = rowSums[i];
                }
            }
            Console.WriteLine("\nМаксимальная сумма элементов: " + maxSum);
        }
    }
}
