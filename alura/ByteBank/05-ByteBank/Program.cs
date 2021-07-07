using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora C#";
            gabriela.cpf = "123.123.133-33";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;
            conta.agencia = 987;
            conta.numero = 12345;
            conta.saldo = 500;

            conta.titular.nome = "Gabriela Costa";

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta);

            Console.ReadLine();
           

        }
    }
}
