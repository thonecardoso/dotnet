using System;
using ByteBank.Modelos;

namespace ByteBank.SitemaInterno
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente(847, 76222);
            Console.WriteLine(contaCorrente.Agencia);
            Console.ReadLine();
        }
    }
}