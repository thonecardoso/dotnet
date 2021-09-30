using System;

namespace _3302_Resposta_Certa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var i = 0;
            while (true)
            {
                var p = Console.ReadLine();
                if (string.IsNullOrEmpty(p))
                    break;
                Console.WriteLine($"resposta {++i}: {p}");
            }
        }
    }
}
