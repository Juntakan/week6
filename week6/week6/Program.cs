using System;
using System.Net; // for web client
using System.IO; // for stream writer
namespace week6
{
    class Program
    {
        static void Main()
        {
            int val;   // do not initial value
            refMethod(out val);
            Console.WriteLine(val);
            Console.ReadLine();
        }

        static void refMethod(out int i)
        {
           i = 34;
            i = i + 1;
        }

    }
}
    
    

