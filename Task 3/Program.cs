using System;

namespace Task_3
{
    internal class Program
    {
        static void GetArray(int[] A, int i)
        {
            if (i >= 0)
            {
                Console.Write(A[i] + " ");
                GetArray(A, i - 1);
            }
        }

        static void Main()
        {
            int[] A = { 1, 2, 3, 4, 5, 8, 9, 1 };

            Console.WriteLine("Элементы массива с конца:");
            GetArray(A, A.Length - 1);
            Console.ReadKey();
        }
    }
}