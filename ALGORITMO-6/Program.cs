//determinar el area de un triangulo

using System;

namespace algoritmo_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int bas = 0;int altura = 0;
            Console.Write("ingrese la base: ");
            bas = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingrese la altura: ");
            altura = Convert.ToInt32(Console.ReadLine());

            int area = bas * altura / 2;
            Console.WriteLine(area);
        }
    }
}
