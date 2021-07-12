using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args)
        {
            var enderecoDoArquivo = "contas.txt";

            

            var fluxoDoArquivo = new FileStream(enderecoDoArquivo,FileMode.Open);

            var buffer = new byte[1024]; // 1kb
            var numeroDeBytesLidos = -1;

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }
            

            
            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            // var utf8 = new UTF8Encoding();
            // var utf8 = Encoding.Default;
            var utf8 = Encoding.UTF8;

            var texto = utf8.GetString(buffer);
            Console.Write(texto);
            
            // foreach (var meuByte in buffer)
            // {
            //     Console.Write(meuByte);
            //     Console.Write(' ');
            // }
        }
    }
} 
 