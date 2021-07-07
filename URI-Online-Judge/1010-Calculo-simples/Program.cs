using System;

namespace _1010_Calculo_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] l1 = Console.ReadLine().Split(' ');
            string[] l2 = Console.ReadLine().Split(' ');
            double resultado = Convert.ToDouble(l1[1]) 
                * Convert.ToDouble(l1[2]) 
                + Convert.ToDouble(l2[1]) 
                * Convert.ToDouble(l2[2]);
            Console.WriteLine($"VALOR A PAGAR: R$ {resultado:F2}");
        }
    }
}
