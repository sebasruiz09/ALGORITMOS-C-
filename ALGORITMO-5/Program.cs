//imprimir los numeros pares entre dos numeros pedidos por teclado

using System;

namespace algoritmo_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0; int numero2 = 0;
            Console.Write("Ingrese número 1: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese número 2: ");
            numero2 = int.Parse(Console.ReadLine());
            int contador = numero1;
            while (contador <= numero2)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador++;
        }
        }
    }
}
