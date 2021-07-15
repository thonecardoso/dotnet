using System;

namespace _1011_Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            var raio = Convert.ToDouble(Console.ReadLine());
            double volume = 4.0 / 3 * 3.14159 * Math.Pow(raio, 3);
            Console.WriteLine($"VOLUME = {volume:f3}");
        }
    }
}
