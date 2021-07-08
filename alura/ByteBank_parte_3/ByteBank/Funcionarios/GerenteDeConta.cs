using System;
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : Autenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando um GerenteDeConta");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * .25;
        }
    }
}