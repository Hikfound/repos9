using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] array = { 3, 9, 15, 25, 7, 33, 17, 85, 12, 49 };
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                count += array[i];
                Console.WriteLine($"{i + 1} Груз={array[i]}");
            }
            Console.WriteLine();
            Console.WriteLine($"Общая масса груза={count}");
            Console.Read();
        }
    }
}
