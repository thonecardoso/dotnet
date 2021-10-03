using System;
using System.Collections.Generic;
using System.Linq;

namespace _1800_Onde_Estao_Minhas_Chaves
{
    class Program
    {
        static void Main(string[] args)
        {
            var qt = Console.ReadLine().Split().Take(1).Select(v => int.Parse(v)).ToArray().First();
            var aux = Console.ReadLine().Split().ToList();
            var dic = new Dictionary<string, int>();
            aux.ForEach(v => {
                if (!dic.ContainsKey(v))
                        dic.Add(v, 0); 
            });
            for(int i=0; i<qt; i++)
            {
                var x = Console.ReadLine();
                if (dic.ContainsKey(x))
                    Console.WriteLine(0);
                else
                {
                    dic.Add(x, 0);
                    Console.WriteLine(1);
                }
                    
            }   
        }
    }
}
