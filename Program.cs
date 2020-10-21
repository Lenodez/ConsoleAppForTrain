using System;

namespace ConsoleAppForTrain
{
    class Program
    {

        static int F(params int[] a)
        {
            int s = 0;
            foreach (int x in a)
            {
                s += x;
            }
            return s;
        }
        static void Main()
        {
            int a = 1, b = 2, c = 3, d = 4;
            Console.WriteLine(F());
            Console.WriteLine(F(a));
            Console.WriteLine(F(a, b));
            Console.WriteLine(F(a, b, c));
            Console.WriteLine(F(a, b, c, d));
        }



    }
}
