using System;
using System.Net;

namespace ConsoleAppForTrain
{
    class Program
    {


        static void Main()
        {
            IPHostEntry host1 = Dns.GetHostEntry("www.microsoft.com");
            Console.WriteLine(host1.HostName);
            foreach (IPAddress ip in host1.AddressList)
                Console.WriteLine(ip.ToString());

            Console.WriteLine();

            IPHostEntry host2 = Dns.GetHostEntry("google.com");
            Console.WriteLine(host2.HostName);
            foreach (IPAddress ip in host2.AddressList)
                Console.WriteLine(ip.ToString());

            IPHostEntry myPage = Dns.GetHostEntry("vk.com");
            Console.WriteLine(myPage.HostName);
            foreach (IPAddress ip in myPage.AddressList)
                Console.WriteLine(ip.ToString());

            IPHostEntry habrahabr = Dns.GetHostEntry("habr.com");
            Console.WriteLine(habrahabr.HostName);
            foreach (IPAddress ip in habrahabr.AddressList)
                Console.WriteLine(ip.ToString());
        }




    }
}
