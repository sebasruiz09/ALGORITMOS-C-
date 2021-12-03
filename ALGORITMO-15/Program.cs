//algoritmo Numero Perfecto
using System;

namespace algoritmo_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.Write("numero :");
            x = Int32.Parse(Console.ReadLine());
            int sum = 0;;
            for (int i = 1; i < x; i++)
            {
                if ((x % i) == 0)
                {
                    sum=+1;
                }
            }
                if (x == sum)
                {  
                    Console.Write("el numero es perfecto: " + Convert.ToString(x));
                }
                else
                {
                    Console.Write("el numero no es perfecto");
                }

        }
    }
}
