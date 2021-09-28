using System;
using System.Text.RegularExpressions;

namespace _2126_Procurando_Subsequencias
{
    class Program
    {
        static void Main(string[] args)
        {
            var caso = 0;
            while (true)
            {
                var sub = Console.ReadLine();
                if (String.IsNullOrEmpty(sub))
                    break;
                var str = Console.ReadLine();

                var rx = new Regex(sub);
                var qt = rx.Matches(str);

                Console.WriteLine($"Caso #{++caso}:");
                if(qt.Count == 0)
                {
                    Console.WriteLine("Nao existe subsequencia\n");
                }
                else
                {
                    Console.WriteLine($"Qtd.Subsequencias: {qt.Count}");
                    Console.WriteLine($"Pos: {str.LastIndexOf(sub) + 1}\n");
                }

            }
        }
    }
}
