using System;

namespace _1006_Media_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double media = (a * 2 + b * 3 + c * 5) / 10.0;
            Console.WriteLine($"MEDIA = {media:F1}");
        }
    }
}
