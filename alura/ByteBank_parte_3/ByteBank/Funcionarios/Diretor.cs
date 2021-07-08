using System;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            return Salario * .5;
        }

        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando um Diretor");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}