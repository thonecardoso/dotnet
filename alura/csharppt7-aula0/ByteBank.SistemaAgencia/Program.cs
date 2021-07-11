using System;
using System.Collections.Generic;
using System.Linq;
using ByteBank.Modelos;
using ByteBank.Modelos.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListadeContas();


            Console.ReadLine();
        }


        static void ListadeContas()
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(453, 1234),
                new ContaCorrente(453, 5434),
                new ContaCorrente(433, 1874),
                new ContaCorrente(233, 0934),
                null,
                new ContaCorrente(111, 2334),
                new ContaCorrente(453, 1134),
            };

            // contas.Sort();
            //contas.Sort(new ComparadorContaCorrentePorAgencia());
            var teste = contas.OrderBy(conta =>
            {
                if (conta == null)
                {
                    return int.MaxValue;
                }
                
                return conta.Agencia;
            });

            foreach (var conta in teste)
            {
                if(conta == null)
                    Console.WriteLine("null");
                else
                    Console.WriteLine($"Conta número {conta.Numero:d4}, ag. {conta.Agencia}");
            }
        }


        static void ListGenerica()
        {
            var idades = new List<int>();

            idades.Add(10);
            idades.Add(5);
            idades.Add(4);

            ListExtensoes.AdicionarVarios(idades, 1, 5687, 1987, 1567, 987);

            idades.AdicionarVarios(3, 4, 5, 2, 1);

            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                int idade = (int) idades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }


            var nomes = new List<string>()
            {
                "ana",
                "ricardo",
                "paulo",
                "danilo",
                "abadia",
                "luana",
                "inácia"
            };

            nomes.Sort();


            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }

        static void ListaGenerica()
        {
            Lista<int> listaDeIdades = new Lista<int>();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int) listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
        }

        static void TesteArray3()
        {
            ContaCorrente contaDoGui = new ContaCorrente(11111, 1111111);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754)
            };

            ListaDeContaCorrente lista = new ListaDeContaCorrente(20);

            lista.AdicionarVarios(contas);

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }

        static void TesteArray2()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente(20);

            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            ContaCorrente contaDoGui = new ContaCorrente(11111, 1111111);
            lista.Adicionar(contaDoGui);
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }

        static void TesteArray()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente(20);

            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            ContaCorrente contaDoGui = new ContaCorrente(11111, 1111111);
            lista.Adicionar(contaDoGui);
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));

            lista.EscreverListaNaTela();

            lista.Remover(contaDoGui);

            Console.WriteLine("Após remover o item");

            lista.EscreverListaNaTela();
        }

        static void TestaArraydeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 4456668),
                new ContaCorrente(874, 7781438),
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }

            Console.ReadLine();
        }
    }
}