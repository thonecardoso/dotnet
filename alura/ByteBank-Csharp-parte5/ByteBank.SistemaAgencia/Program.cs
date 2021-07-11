using System;
using System.Text.RegularExpressions;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            TesteRegex();
            
            // Teste1();
            // Teste2();
        }

        public static void TesteRegex()
        {
            // string padrao =
            //     "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";

            // string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            // string padrao = "[0-9]{4}[-][0-9]{4}";
            // string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            // string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Meu nome é Guilherme, me ligue em 4784-4546";
            
            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));
            
            Match resultado = Regex.Match(textoDeTeste, padrao);
            Console.WriteLine(resultado.Value);
            
            Console.ReadLine();
        }

        public static void Teste2()
        {
            string urlTeste = "https://www.bytebank.com/cambio";
            
            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio"));

            Console.WriteLine(urlTeste.Contains("bytebank"));
        }

        public static void Teste1()
        {
            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

            Console.WriteLine(extratorDeValores.GetValor("valor"));

            Console.ReadLine();
        }
    }
}