//  

using System;

namespace algoritmo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            if (i % 3 == 0 || i % 2 == 0)
                Console.Write("{0}|", i);
        }
    }
}
