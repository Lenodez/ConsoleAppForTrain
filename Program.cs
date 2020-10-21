using System;
using System.Net;
using System.IO;

namespace ConsoleAppForTrain
{
    class Program
    {


        static void Main(string[] args)
        {
            WebClient client = new WebClient();

            using (Stream stream = client.OpenRead("http://somesite.com/sometext.txt"))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }

            Console.WriteLine("Файл загружен");
            Console.Read();
        }




    }
}
