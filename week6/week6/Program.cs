using System;
using System.Net; // for web client
using System.IO; // for stream writer
namespace week6
{
    class Program
    {
        static void Main()
        {
            sayHello("Hello World.");
            Console.ReadLine();
        }

        static void sayHello(string str)
        {
            Console.WriteLine(str);
        }

    }
}

