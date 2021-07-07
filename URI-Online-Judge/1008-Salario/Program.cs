using System;

namespace _1008_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int horas = Int32.Parse(Console.ReadLine());
            double salario = Double.Parse(Console.ReadLine());
            Console.WriteLine($"NUMBER = {n}");
            Console.WriteLine($"SALARY = U$ {horas * salario:F2}");
        }
    }
}
