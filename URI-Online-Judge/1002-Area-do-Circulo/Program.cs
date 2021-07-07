using System;

namespace _1002_Area_do_Circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = Convert.ToDouble(Console.ReadLine());
            double resposta = 3.14159 * raio * raio;
            Console.WriteLine($"A={resposta:F4}");
        }
    }
}
