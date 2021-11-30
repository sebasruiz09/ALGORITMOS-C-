//imprimir los primeros 100 numeros de forma inversa

using System;

namespace algoritmo_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 100;
            while (contador >= 1)
            {
                Console.WriteLine(contador);
                contador -= 1;
            }
        }              
    }
}
