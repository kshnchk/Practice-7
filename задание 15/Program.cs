/*
Дана матрица N x M. Сжать массив, удалив из него все элементы,
величина которых находится в интервале [a, b]. Освободившиеся в конце
массива элементы заполнить нулями.
*/

namespace задание_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            int M = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[N, M];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = rand.Next(1, 101);
                }
            }
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите границы интервала [a, b]:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int[] flatArray = new int[N * M];
            int index = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (matrix[i, j] < a || matrix[i, j] > b)
                    {
                        flatArray[index++] = matrix[i, j];
                    }
                }
            }
            for (; index < flatArray.Length; index++)
            {
                flatArray[index] = 0;
            }
            Console.WriteLine("\nСжатый массив:");
            for (int i = 0; i < flatArray.Length; i++)
            {
                Console.Write(flatArray[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
