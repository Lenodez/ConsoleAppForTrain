using System;
using System.Net;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppForTrain
{
    class Program
    {


        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }

        static void Main(string[] args)
        {
            int S = Fibonachi(45);
            Console.WriteLine(S);
        }




    }
}
