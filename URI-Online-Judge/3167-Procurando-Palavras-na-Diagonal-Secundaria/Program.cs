using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _3167_Procurando_Palavras_na_Diagonal_Secundaria
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(inp => int.Parse(inp)).ToArray();
            int linha = input[1];
            int coluna = input[2];



            var list = new List<Regex>();

            for (int w = 0; w < input[0]; w++)
            {
                list.Add(new Regex(Console.ReadLine().ToLower()));
            }

            var matrix = new List<string>();

            for (int w = 0; w < linha; w++)
            {
                matrix.Add(new string(Console.ReadLine().ToLower().Reverse().ToArray()));
            }

            int i = 0;
            int j = 0;

            var principal = new StringBuilder("", 1000);
            for (i = 0; i < linha && i < coluna; i++)
            {
                principal.Append(matrix[i][i]);
            }
            int k;
            var acimaPrincipal = new StringBuilder("", 1000);
            for (i = 0; i < linha || i < coluna; i++)
            {
                for (j = i + 1, k = 0; j < coluna && k < linha; j++, k++)
                {
                    acimaPrincipal.Append(matrix[k][j]);
                }
                acimaPrincipal.Append("|||");
            }

            var abaixoPrincipal = new StringBuilder("", 1000);
            for (i = 1; i < linha; i++)
            {
                for (j = 0, k = i; j < coluna && k < linha; j++, k++)
                {
                    abaixoPrincipal.Append(matrix[k][j]);
                }

                abaixoPrincipal.Append("|||");
            }



            foreach (var s in list)
            {
                if (s.IsMatch(principal.ToString()) || s.IsMatch(new string(principal.ToString().Reverse().ToArray())))
                {
                    Console.WriteLine($"1 Palavra \"{s}\" na diagonal secundaria");
                }
                else if (s.IsMatch(acimaPrincipal.ToString()) || s.IsMatch(new string(acimaPrincipal.ToString().Reverse().ToArray())))
                {
                    Console.WriteLine($"2 Palavra \"{s}\" acima da diagonal secundaria");
                }
                else if (s.IsMatch(abaixoPrincipal.ToString()) || s.IsMatch(new string(abaixoPrincipal.ToString().Reverse().ToArray())))
                {
                    Console.WriteLine($"3 Palavra \"{s}\" abaixo da diagonal secundaria");
                }
                else
                {
                    Console.WriteLine($"4 Palavra \"{s}\" inexistente");
                }
            }
        }

    }
}
