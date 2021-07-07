﻿namespace ByteBank.Funcionarios
{
    public class Funcionario
    {

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }


        public virtual double GetBonificacao()
        {
            return Salario * .10;
        }
    }
}