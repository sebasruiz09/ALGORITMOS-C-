//sacar promedio de un arreglo de 20 datos numeros aleoratorios entre 10 y 30

using System;
using System.Collections.Generic;

namespace algoritmo_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Random numero = new Random();
            for (int i = 0; i <= 20; i++)
            {
                numeros.Add(numero.Next(10,30));
            }
            int sum = 0;
            foreach (var dato in numeros)
            {
                sum = sum + dato;
                Console.WriteLine(dato);
            }
            int promedio = sum / 20;
            Console.WriteLine(promedio);
            
        }
    }
}
