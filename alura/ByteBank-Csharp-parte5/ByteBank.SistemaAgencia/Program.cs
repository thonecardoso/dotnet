using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "pagina?argumentos";
            int indiceInterrogacao = url.IndexOf('?');
            var argumentos = url.Substring(indiceInterrogacao + 1).Split('&');
            Console.WriteLine(url[indiceInterrogacao]);

            for (int i = 0; i < argumentos.Length; i++)
            {
            Console.WriteLine(argumentos[i].Split('=')[1]);    
            }
            Console.ReadLine();
        }
    }
}