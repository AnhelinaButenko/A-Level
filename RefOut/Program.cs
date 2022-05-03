using System;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            bool parseResult = int.TryParse(s, out var sInt);


            int val = 10;
            int outVal;

            RefMethod(ref val, out outVal);
        }

        static void RefMethod(ref int value, out int outValue)
        {
            value = 100;
            outValue = 1000;
        }
    }
}