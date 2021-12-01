// ordenar un arreglo de x numeros con el metodo de la burbuja
using System;

namespace algoritmo_9
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
            Console.Write("arreglo sin organizar: ");
            foreach (var item in numeros)
            { 
                Console.Write(Convert.ToString(item) + " ");
            }
            int t = 0;
            for (int a = 1; a < numeros.Length; a++)
            {
                for (int b = numeros.Length - 1; b >= a; b--)
                {
                    if (numeros[b - 1] > numeros[b])
                    {
                        t = numeros[b - 1];
                        numeros[b - 1] = numeros[b];
                        numeros[b] = t;
                    }
                }
            }
            Console.WriteLine("\n arreglo organizado:");
            foreach (var item in numeros)
            {
                
                Console.Write(Convert.ToString(item) + " ");
            }
        }
    }
}
