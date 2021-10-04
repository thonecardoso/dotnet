using System;
using System.Linq;

namespace _3214_Refrigerante
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = Console.ReadLine().Split().Select(v => int.Parse(v)).ToArray();
            var total = Total(i[0] + i[1], i[2]);
            Console.WriteLine(total);
        }

        static int Total(int garrafas, int preco)
        {
            if (garrafas < preco) return 0;

            return garrafas / preco + Total(garrafas / preco + garrafas % preco, preco);
        }
    }
}
