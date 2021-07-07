using System;

namespace _1005_Media_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine($"MEDIA = {(a*3.5+b*7.5)/11.0:F5}");
        }
    }
}
