using System;
using System.Linq;

namespace ConsoleAppForTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray; //создаем ссылку на массив
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            myArray = new int[n]; //выделяем память под массив требуемой длины
            for (int i = 0; i < n; i++) //вводим элементы массива с клавиатуры
            {
                Console.Write("A[{0}]= ", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }
            foreach (int elem in myArray) //выводим массив на экран
            {
                Console.Write("{0} ", elem);
            }
        }
    }
}
