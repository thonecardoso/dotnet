using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Gabriela";
            cliente.CPF = "123.123.123-12";
            cliente.Profissao = "Analista de Sistemas";

            conta.titular = cliente;
            conta.Saldo = 10;


            Console.WriteLine(conta.Saldo);
            Console.ReadLine();
        }
    }
}
