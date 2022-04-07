using System;

namespace ArrayHW2
{
    class Program
    {       
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rand = new Random();
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (rand.Next(-100, 100));
                Console.WriteLine(array[i]);
            }

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];               
            }
            Console.WriteLine($"Sum: {sum}");
        }
  
    }
}
