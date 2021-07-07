using System;

namespace _1009_Salario_com_bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            double salario = Convert.ToDouble(Console.ReadLine());
            double vendas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"TOTAL = R$ {salario + vendas * 0.15:F2}");
        }
    }
}
