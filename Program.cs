using System;

namespace ConsoleAppForTrain
{
    class Program
    {

        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Input(out int[,] a)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m= ");
            int m = int.Parse(Console.ReadLine());
            a = new int[n, m];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Change(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] % 2 == 0)
                    {
                        a[i, j] = 0;
                    }
        }
        static void Main()
        {
            int[,] a;
            Input(out a);
            Console.WriteLine("Исходный массив:");
            Print(a);
            Change(a);
            Console.WriteLine("Измененный массив:");
            Print(a);
        }
        



    }
}
