using System;

namespace laba3_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] mass = new int[7, 7];
            Console.WriteLine("Изначальный массив: ");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 7; j++)
                {
                    mass[i, j] = rand.Next(10, 99);
                    Console.Write(mass[i, j] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Повёрнутый массив: ");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(mass[7 - j - 1, i] + " ");
                }
            }
        }
    }
}
