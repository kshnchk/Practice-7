/*
Дана матрица N x M. Все элементы равные 0 поменять местами с
элементами последней строки (если в последней строке все элементы
равны 0, то менять местами с элементами предпоследней строки).
*/

namespace задание_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                        matrix[i, j] = rand.Next(-10, 11); 
                    }
                }
                Console.WriteLine("Сгенерированная матрица:");
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                int lastRowIndex = N - 1;
                int lastNonZeroRow = lastRowIndex;
                while (lastNonZeroRow >= 0)
                {
                    bool allZero = true;
                    for (int j = 0; j < M; j++)
                    {
                        if (matrix[lastNonZeroRow, j] != 0)
                        {
                            allZero = false;
                            break;
                        }
                    }
                    if (!allZero)
                    {
                        break;
                    }

                    lastNonZeroRow--;
                }
                if (lastNonZeroRow < 0) return;

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (matrix[i, j] == 0)
                        {
                            int temp = matrix[i, j];
                            matrix[i, j] = matrix[lastNonZeroRow, j];
                            matrix[lastNonZeroRow, j] = temp;
                        }
                    }
                }
                Console.WriteLine("\nМатрица после замены:");
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
