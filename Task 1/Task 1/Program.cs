using System;

namespace Task_1
{
    internal class Program
    {
        static void OutputNumber(int M, int N)
        {
            if (M <= N)
            {
                Console.Write(M + " ");
                OutputNumber(M+1, N);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("M = ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Список натуральных чисел от {M} до {N}:");
            OutputNumber(M,N);
            Console.ReadKey();
        }
    }
}
