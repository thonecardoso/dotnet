using System;

namespace _3004_Envelopes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var n = int.Parse(input);

            for (int i = 1; i <= n; i++)
            {
                var linha = Console.ReadLine().Split();
                var a = new int[] { int.Parse(linha[0]), int.Parse(linha[1]) };
                var b = new int[] { int.Parse(linha[2]), int.Parse(linha[3]) };

                Array.Sort(a);
                Array.Sort(b);

                var res = a[0] < b[0] && a[1] < b[1] ? "S" : "N";
                Console.WriteLine(res);

            }
            
        }


    }
}
