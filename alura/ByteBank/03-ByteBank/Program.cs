using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.numeroAgencia = 123;
            contaDaGabriela.numero = 12345;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.numeroAgencia = 123;
            contaDaGabrielaCosta.numero = 12345;

            Console.WriteLine(contaDaGabrielaCosta == contaDaGabriela);

            Console.ReadLine();

        }
    }
}
