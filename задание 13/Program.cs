/*
Вывести на экран матрицу 8x5, элементами которой являются целые
случайные числа из интервала [20,40]. Определить номер строки,
содержащей не более 3-х чётных чисел.
*/

namespace задание_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 8;
            int cols = 5;
            int[,] matrix = new int[rows, cols];
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(20, 41);
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
            Console.WriteLine("\nНомера строк с не более чем 3 четными числами:");
            for (int i = 0; i < rows; i++)
            {
                int evenCount = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        evenCount++;
                    }
                }
                if (evenCount <= 3)
                {
                    Console.WriteLine("Строка " + (i + 1));
                }
            }
        }
    }
}
