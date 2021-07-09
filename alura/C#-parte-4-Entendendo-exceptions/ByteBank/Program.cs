using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch(Exception)
            {
                Console.WriteLine("CATCH NO METODO MAIN");
            }

            Console.ReadLine();

        }
        
        private static void CarregarContas()
        {
            
            using (LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {
                leitor.LerProximaLinha();
            }
            
            
            
            /*
             
            LeitorDeArquivos leitor = null;
            try
            {
                leitor = new LeitorDeArquivos("contas1.txt");

                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
            catch(IOException)
            {
                Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            }

            finally
            {
                Console.WriteLine("Executando o finally");
                if(leitor != null)
                {
                    leitor.Fechar();
                }
            }
            
            */
        }

        public static void TestaInnerException()
        {
            ContaCorrente conta1 = new ContaCorrente(4564, 789684);
            ContaCorrente conta2 = new ContaCorrente(7891, 456794);
            
            try
            {
                // conta1.Transferir(10000, conta2);
                conta1.Transferir(101, conta2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
                Console.WriteLine(e.StackTrace);
                
            }

            try
            {
                conta1.Sacar(1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.WriteLine(conta1.ContadorSaquesNaoPermitidos);
            Console.WriteLine(conta1.ContadorTransferenciasNaoPermitidas);
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
            }
        }
    }
}
