using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";


            Console.WriteLine(contaDoBruno.saldo);
            bool saque = contaDoBruno.Sacar(500);
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(!saque ? "Saldo Insuficiente" : "Saque Realizado com Sucesso!");

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);
            saque = contaDoBruno.Sacar(500);
            Console.WriteLine(!saque ? "Saldo Insuficiente" : "Saque Realizado com Sucesso!");

            ContaCorrente contaDaRaquel = new ContaCorrente();

            contaDoBruno.titular = "Raquel";

            Console.WriteLine("Saldo Bruno R$" + contaDoBruno.saldo);
            Console.WriteLine("Saldo Raquel R$" + contaDaRaquel.saldo);
            bool tranferido = contaDoBruno.Transferir(50, contaDaRaquel);
            Console.WriteLine(!tranferido ? "Saldo Insuficiente" : "Tranferência Realizada com Sucesso!");
            Console.WriteLine("Saldo Bruno R$" + contaDoBruno.saldo);
            Console.WriteLine("Saldo Raquel R$" + contaDaRaquel.saldo);

            Console.ReadLine();
        }
    }
}
