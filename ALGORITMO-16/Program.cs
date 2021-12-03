//conversion de temperatura / C - K / C - F

using System;

namespace algoritmo_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int celcius = 0, farenheit = 0, kelvin = 0;
            string tipo = " ";
            Console.Write("tipo de temperatura a convertir: ");
            tipo = Convert.ToString(Console.ReadLine());
            Console.Write("\n grados");
            celcius = Int32.Parse(Console.ReadLine());

            if(tipo == "fahrenheit")
            {
                farenheit = (celcius * 9/5) + 32;
                Console.Write("grados fahrenheit: " + Convert.ToString(farenheit));
            }
            else
            {
                if(tipo == "kelvin")
                {
                    kelvin = celcius + 273; 
                    Console.Write("kelvin: " + Convert.ToString(kelvin));
                }
            }
        }
    }
}
