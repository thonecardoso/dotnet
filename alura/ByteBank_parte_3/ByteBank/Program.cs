using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            
            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.Salario = 2000;
            carlos.CPF = "123.123.123-12";
            
            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "123.123.321-23";
            roberta.Salario = 5000;

            Funcionario robertaTeste = roberta;
            
            Console.WriteLine("Bonificação de uma referencia de Funcionario: " + robertaTeste.GetBonificacao());
            Console.WriteLine("Bonificação de uma referencia de Diretor: " + roberta.GetBonificacao());
            
            gerenciador.Registrar(roberta);
            
            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());
                
            
            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
            
            Console.WriteLine("Total de Bonificação a ser pagas: R$" + gerenciador.GetTotalBonificacao());
            
        }
    }
}