using System;
using System.Collections.Generic;
using System.Linq;

namespace _3301_Sobrinho_do_Meio
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var p = Console.ReadLine();
                if (string.IsNullOrEmpty(p))
                    break;

                var v = p.Split().Select(n => int.Parse(n)).ToArray();

                var h = new SortedDictionary<int, string>();

                h.Add(v[0], "huguinho");
                h.Add(v[1], "zezinho");
                h.Add(v[2], "luisinho");

                Console.WriteLine(h.Skip(1).First().Value);
            }
        }
    }
}