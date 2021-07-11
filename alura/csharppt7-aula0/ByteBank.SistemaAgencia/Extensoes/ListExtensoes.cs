using System;
using System.Collections.Generic;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        static void Test()
        {
            List<int> idades = new List<int>();
            
            idades.Add(14);
            idades.Add(14);
            idades.Add(14);
            
            //ListExtensoes<int>.AdicionarVarios(idades, 2, 3, 4);
            idades.AdicionarVarios( 2, 3, 4);

            List<string> nomes = new List<string>();
            
            nomes.Add("Guilherme");
            nomes.Add("Guilherme");
            nomes.Add("Guilherme");
            
            //ListExtensoes<string>.AdicionarVarios(nomes, "asdf", "asdf");
            nomes.AdicionarVarios( "asdf", "asdf");
        }
    }
}