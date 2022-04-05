using System;

namespace A_Level
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Anhelina";
            string surName = "Butenko";
            int age = 21;
            Console.WriteLine (name + " " + surName + " " +  $"до начала новой жизни вам осталось {40 - age} лет");
        }
    }
}
