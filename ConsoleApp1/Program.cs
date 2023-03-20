using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 23;
            Random rnd = new Random();
            int[] array = new int[23];
            int count = 0;
            for (int i = 0; i <= n; i++)
            {
                array[i] = rnd.Next(160, 190);
                count += array[i];
                Console.WriteLine($"{i + 1} Студент={array[i]}");  
            }
            Console.WriteLine($"Средний рост={count / n}");
            Console.Read();
        }
    }
}
