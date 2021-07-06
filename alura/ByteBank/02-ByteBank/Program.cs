using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();

            

            conta.saldo = 100;

            Console.WriteLine("Titular: " + conta.titular);
            Console.WriteLine("Agencia: " + conta.numeroAgencia);
            Console.WriteLine("Número: " + conta.numero);
            Console.WriteLine("Saldo R$" + conta.saldo);

            Console.ReadLine();
        }
    }
}
