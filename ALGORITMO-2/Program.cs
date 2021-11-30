//hallar numeros pares del 1 al 100

using System;

namespace algoritmo_2
{
    class ejercicio
    {
        static void Main()
        {
            int i, impar = 0;

            for (i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("{0}|", i);
                    impar = impar + 1;
                }
            }
        }
    }
}