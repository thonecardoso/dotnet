using System;
using System.Collections.Generic;

namespace primeiros_passos_com_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();

            var opcaoUsuario = getOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Aluno aluno = new Aluno();
                        Console.WriteLine("Informe o nome do aluno");
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("Informe a nota do aluno");
                        
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal");
                        }
                        
                        alunos.Add(aluno);
                        break;
                    case "2":
                        ListarAlunos(alunos);
                        break;
                    case "3":
                        Console.WriteLine($"--------------------------");
                        Console.WriteLine($"media geral dos alunos {CalcularMedia(alunos)}");
                        Console.WriteLine($"--------------------------");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                opcaoUsuario = getOpcaoUsuario();
            }
        }

        private static void ListarAlunos(List<Aluno> alunos)
        {
            var i = 1;
            foreach (var aluno in alunos)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine($"{i++} - Nome: {aluno.Nome} - Nota: {aluno.Nota}");
                Console.WriteLine("--------------------------");
            }
            Console.WriteLine();
        }
        
        private static decimal CalcularMedia(List<Aluno> alunos)
        {
            var i = 0;
            decimal media = 0;
            foreach (var aluno in alunos)
            {
                i++;
                media += aluno.Nota;
            }

            return  (media / i);
        }

        private static string getOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("x - Para sair\n");

            return Console.ReadLine();
        }
    }

    class Aluno
    {
        public string Nome { get; set; }
        public decimal Nota { get; set; }
    }

    enum Conceito
    {
        A,
        B,
        C,
        D,
        E
    }
}