//sucesion de fionacci
using System;

namespace algoritmo_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int rango = 0,p = 0,s = 1,sig = 0;
            Console.Write("ingrese el rango de la serie: ");
            rango = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= rango; i++)
            {
                if (i <= 1)
                {
                    sig = i;
                }
                else
                {
                    sig = p + s;
                    p = s;
                    s = sig;
                }
                Console.Write("{0} - ",sig);
            }
            Console.ReadKey();

        }
    }
}
