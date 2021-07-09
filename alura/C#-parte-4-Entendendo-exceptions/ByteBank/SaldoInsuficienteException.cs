using System;

namespace ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double Saque { get; }

        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(string message) : base(message)
        {
        }

        public SaldoInsuficienteException(double saldo, double saque) 
            : this($"Tentativa de saque no valor de R${saque} em uma conta com saldo de R${saldo}")
        {
            Saldo = saldo;
            Saque = saque;
        }
    }
}