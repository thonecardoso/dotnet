using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3166_Procurando_Palavras_na_Diagonal_Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(inp => int.Parse(inp)).ToArray();
            int linha = input[1];
            int coluna = input[2];



            var list = new List<Regex>();

            for(int w = 0; w<input[0]; w++)
            {
                list.Add(new Regex(Console.ReadLine().ToLower()));
            }

            var matrix = new List<string>();

            for (int w = 0; w < linha; w++)
            {
                matrix.Add(Console.ReadLine());
            }
            
            int i = 0;
            int j = 0;

            var principal = "";
            for(i = 0; i<linha && i<coluna; i++)
            {
                principal += matrix[i][i];
            }
            int k;
            var acimaPrincipal = "";
            for (i = 0; i < linha || i < coluna; i++)
            {
                for (j = i + 1, k = 0; j < coluna && k<linha; j++, k++)
                {
                    acimaPrincipal += matrix[k][j];
                }
                acimaPrincipal += "|||";
            }

            var abaixoPrincipal = "";
            for (i = 1; i < linha ; i++)
            {
                for (j = 0, k = i; j<coluna && k<linha; j++, k++)
                {
                    abaixoPrincipal += matrix[k][j];
                }

                abaixoPrincipal += "|||";
            }

            Console.WriteLine($"{principal}\nacima principal={acimaPrincipal}\n{abaixoPrincipal}");

            principal +="|||" + new string(principal.Reverse().ToArray());
            acimaPrincipal += "|||" + new string(acimaPrincipal.Reverse().ToArray());
            abaixoPrincipal += "|||" + new string(abaixoPrincipal.Reverse().ToArray());

            foreach(var s in list)
            {
                if(s.IsMatch(principal.ToLower()))
                {
                    Console.WriteLine($"1 Palavra \"{s}\" na diagonal principal");
                }
                else if (s.IsMatch(acimaPrincipal.ToLower()))
                {
                    Console.WriteLine($"2 Palavra \"{s}\" acima da diagonal principal");
                }
                else if (s.IsMatch(abaixoPrincipal.ToLower()))
                {
                    Console.WriteLine($"3 Palavra \"{s}\" abaixo da diagonal principal");
                }
                else
                {
                    Console.WriteLine($"4 Palavra \"{s}\" inexistente");
                }
            }
        }
    }
}
