/*
Вывести на экран матрицу 15х9. Найти минимальный элемент в каждой
строке двумерного массива.
*/

namespace задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 15;
            int cols = 9;
            int[,] array = new int[rows, cols];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rand.Next(1, 100);
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


            Console.WriteLine("Минимальные элементы в каждой строке:");
            for (int i = 0; i < rows; i++)
            {
                int minElement = array[i, 0];
                for (int j = 1; j < cols; j++)
                {
                    if (array[i, j] < minElement)
                    {
                        minElement = array[i, j];
                    }
                }
                Console.WriteLine($"Минимум в строке {i + 1}: {minElement}");
            }
        }
    }
}
