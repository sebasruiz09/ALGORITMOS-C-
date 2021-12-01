//algoritmo funcion cuadratica

using System;

namespace algoritmo_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double x1 = 0,x2 = 0;

            Console.Write("ingrese el valor de a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingrese el valor de b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingrese el valor de c: ");
            c = Convert.ToInt32(Console.ReadLine());

            x1 = ((-1 * b) + Math.Sqrt(Math.Pow(b,2)-(4 * a * c))) / (2 * a);
            x2 = ((-1 * b) - Math.Sqrt(Math.Pow(b,2)-(4 * a * c))) / (2 * a);

            Console.Write("valor de x1: {0}",x1 );
            Console.Write("\nvalor de x2: {0}",x2 );
        }
    }
}
