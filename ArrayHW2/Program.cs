using System;

namespace ArrayHW2
{
    class Program
    {       
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (rand.Next(-300, 300));
                Console.WriteLine(array[i]);               
            }

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 100 && array[i] >= -100)
                {
                    count++;
                }
            }
            Console.Write($"Number of elements in the range -100 to 100: {count}");
        }
    }
}
