/*
Вывести на экран матрицу 5х8. Определить номера столбцов, содержащих
хотя бы один отрицательный элемент.
*/

namespace задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            int cols = 8;
            int[,] array = new int[rows, cols];
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rand.Next(-10, 11);
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

            Console.WriteLine("Номера столбцов, содержащих хотя бы один отрицательный элемент:");
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (array[i, j] < 0)
                    {
                        Console.WriteLine("Столбец " + (j + 1));
                        break;
                    }
                }
            }
        }
    }
}
