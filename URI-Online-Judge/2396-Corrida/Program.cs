using System;
using System.Collections.Generic;
using System.Linq;

namespace _2396_Corrida
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var n = int.Parse(input[0]);
            var res = new SortedDictionary<int, int>();

            for(int i = 1; i<=n; i++)
            {
                input = Console.ReadLine().Split();
                res.Add(input.Select(num => int.Parse(num)).Sum(), i);
            }
            foreach(var x in res.Take(3))
            {
                Console.WriteLine(x.Value);
            }
            
        }
    }
}
