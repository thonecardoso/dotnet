using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("888.888.888-88");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("777.777.777-77");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("666.666.666-66");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("555.555.555-55");
            camila.Nome = "Camila";
            
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            var total = gerenciadorBonificacao.GetTotalBonificacao();
            Console.WriteLine($"\nBonificação paga aos Funcionários R${total:f2}");
            Console.WriteLine($"Total Funcionários Registrados: {Funcionario.TotalFuncionarios}");
        }
    }
}