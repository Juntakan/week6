using System;
using System.Net; // for web client
using System.IO; // for stream writer
namespace week6
{
    class Program
    {
        static void Main()
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a && b);
            Console.WriteLine(a || b);
            Console.WriteLine(!b);
            Console.WriteLine(b || true);
            Console.WriteLine((9 > 7) ^ (a == b));
            Console.WriteLine((b != a) || (a == b));
            Console.WriteLine((b != a) && (a == b));
            Console.WriteLine((!a) && (!b));
            Console.WriteLine((!a) || (!b));
        }
        }
    }
    
    

