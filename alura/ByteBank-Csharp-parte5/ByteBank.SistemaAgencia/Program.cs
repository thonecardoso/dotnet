using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente(847, 883929);
            Console.WriteLine(contaCorrente.Numero);
            Console.ReadLine();
        }
    }
}