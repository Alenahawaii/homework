using System;

namespace Task_2
{
    internal class Program
    {
        static int AKR(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (n == 0)
            {
                return AKR(m - 1, 1);
            }
            else
            {
                return AKR(m - 1, AKR(m, n - 1));
            }
        }

        static void Main(string[] args)
        {
            Console.Write("M = ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("N = ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Результат вычисления функции Аккермана ({M},{N}):");
            Console.WriteLine(AKR(M, N));
            Console.ReadKey();
        }
    }
}
