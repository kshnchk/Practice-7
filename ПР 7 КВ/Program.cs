/*
Создать метод для генерации двумерного массива заполненного
рандомными числами с A по B.
*/

namespace задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int lenA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int lenB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минимальное значение: ");
            int minNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальное значение: ");
            int maxNum = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[lenA, lenB];

            Random rand = new Random();
            for (int i = 0; i < lenA; i++)
            {
                for (int j = 0; j < lenB; j++)
                {
                    array[i, j] = rand.Next(minNum, maxNum + 1);
                }
            }
            Console.WriteLine("Сгенерированная матрица:");
            for (int i = 0; i < lenA; i++)
            {
                for (int j = 0; j < lenB; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }           
        }
    }
}
