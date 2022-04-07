using System;
using System.Linq;

namespace ArrayHW2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[20];
            Random rand = new Random();
            int[] B = new int[20];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = (rand.Next(1500));
                Console.WriteLine($"A: {A[i]}");
            }

            Console.WriteLine();

            for (int i = 0; i < B.Length; i++)
            {
                
                if (A[i] <= 888)
                {
                    B[i] = A[i];
                    Console.WriteLine($"B: {B[i]}");
                }            
            }

            Console.WriteLine();

            Array.Sort(B);
            Array.Reverse(B);
            for (int i = 0; i < B.Length; i++)
            {
                Console.WriteLine($"B descending: {B[i]}");
            }
        }
    }
}
