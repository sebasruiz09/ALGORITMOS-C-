//generar 3la siguiente secuencia 0/6 0/8 0/10 0/12...... hasta 0/60 y empieza de nuevo en 1/6
//asi hasta 10/60
using System;


namespace algoritmo_8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int x = 3; x <= 30;x++)
                {
                    int number = x * 2;
                    Console.Write(i + "/" + number + " ");
                }
            }
        }
    }
}
