//crear lineas de una piramide de * dado un numero x;
using System;

namespace algoritmo_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int rango = 0;
            Console.Write("ingrese el numero dado a la piramide: ");
            rango = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < rango; i++)
            {
                Console.WriteLine(new String(' ', rango-i-1) + new String('*', i+i+1));
            }
            Console.ReadLine();
        }
    }
}
