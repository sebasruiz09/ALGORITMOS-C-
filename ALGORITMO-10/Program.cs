//// ordenar un arreglo de x numeros con el metodo de insercion

using System;

namespace algoritmo_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int rango = 0;
            Console.Write("rango de numeros en el arreglo: ");
            rango = Convert.ToInt32(Console.ReadLine());

            Random numero = new Random();

            int[] numeros = new int[rango];
            for (int i = 0; i < rango; i++)
            {
                numeros[i] = numero.Next(0,100);
            }
            Console.Write("\n arreglo sin organizar: ");
            foreach (var item in numeros)
            { 
                Console.Write(Convert.ToString(item) + " ");
            }
            int aux;
            int x;
            for (int i = 0; i < numeros.Length; i++)
            {
                aux = numeros[i];
                x = i - 1;
                while (x >= 0 && numeros[x] > aux)
                {
                    numeros[x + 1] = numeros[x];
                    x--;
                }
                numeros[x + 1] = aux;
            }
            Console.Write("\n arreglo organizado: ");
            foreach (var item in numeros)
            {
                Console.Write(Convert.ToString(item) + " ");
            }
        }
    }
}
