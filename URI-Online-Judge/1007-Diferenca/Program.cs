﻿using System;

namespace _1007_Diferenca
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Int32.Parse(Console.ReadLine());
            int B = Int32.Parse(Console.ReadLine());
            int C = Int32.Parse(Console.ReadLine());
            int D = Int32.Parse(Console.ReadLine());
            int DIFERENCA = (A * B - C * D);
            Console.WriteLine($"DIFERENCA = {DIFERENCA}");
        }
    }
}