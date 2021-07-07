using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 12345);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            
            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Agencia);

            ContaCorrente conta2 = new ContaCorrente(867, 123345);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
        }
    }
}
