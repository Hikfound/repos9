using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            Random rnd = new Random();
            int[] array = new int[14];
            int count = 0;
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i <= n; i++)
            {
                array[i] = rnd.Next(-10, 10);
                Console.WriteLine($"{i + 1} Число={array[i]}");  
                if (array[i] > 0 )
                {
                    count += array[i];
                }
                if (array[i] < 0)
                {
                    count1+= array[i];
                }
                if (array[i] ==0)
                {
                    count2 +=array[i];
                }

            }
            Console.WriteLine($"Положительных={count}\tОтрицательных={count1}\tНулевых={count2}");
            Console.Read();
        }
    }
}
