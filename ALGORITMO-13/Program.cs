//buscar numeros repetidos de un arreglo de 50 numeros aleoratorios
using System;
using System.Collections.Generic;

namespace algoritmo_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int rango = 50;
            Random numero = new Random();

            int[] numeros = new int[rango];
            for (int i = 0; i < rango; i++)
            {
                numeros[i] = numero.Next(0,100);
            }
            Console.WriteLine("datos agregados: ");
            foreach (var item in numeros)
            {   
                
                Console.Write(item + " " );
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                int a = numeros[i];
                int contador = i + 1;

                for (int x = contador; x < numeros.Length; x++)
                {
                    int b = numeros[x];
                    if(a == b)
                    {
                        Console.WriteLine("\nnumero repetido: " + a);
                    }
                }
            }
        }
    }
}
