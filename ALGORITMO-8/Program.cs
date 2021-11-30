//generar 3la siguiente secuencia 1/3 2/6 3/9 4/12...... 10+
using System;
using System.Collections.Generic;

namespace algoritmo_8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int x = 3; x <= 10;x++)
                {
                    int number = x * 2;
                    Console.Write(i + "/" + number + " ");
                }
            }
        }
    }
}
