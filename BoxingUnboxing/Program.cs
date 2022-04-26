using System;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            short val = 100; // 2 bytes

            //boxing
            object boxedVal = val;

            Console.WriteLine(val);
            Console.WriteLine(boxedVal);

            //unboxing          
            val = (short)boxedVal;
            Console.WriteLine(val);
            
            //мы можем сделать анбокснг только в тот тип из которого мы делали боксинг
            //int intVal = (int)boxedVal; // Cast error

            int intVal = (short)boxedVal; // will work
            Console.WriteLine(val);

        }
    }
}
