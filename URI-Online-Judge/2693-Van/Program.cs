using System;
using System.Collections.Generic;
using System.Linq;

namespace _2693_Van
{
    class Program
    {
        static void Main(string[] args)
        {
            var entrada = Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(entrada))
            {
                var n = int.Parse(entrada);
                var lista = new List<string>();
                while (n-- > 0)
                {
                    lista.Add(Console.ReadLine());
                }

                lista.Select(s =>
                {
                    var str = s.Split();

                    return new
                    {
                        nome = str[0],
                        reg = str[1],
                        dist = int.Parse(str[2])
                    };

                })
                    .OrderBy(s=>s.dist)
                    .ThenBy(s=>s.reg)
                    .ThenBy(s=>s.nome)
                    .ToList()
                    .ForEach(s=>Console.WriteLine(s.nome));

                
                entrada = Console.ReadLine();
            }
        }
    }
}
