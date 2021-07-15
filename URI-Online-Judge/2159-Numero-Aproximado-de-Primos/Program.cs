using System;

namespace _2159_Numero_Aproximado_de_Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            var numero = Convert.ToDouble(Console.ReadLine());
            var x = numero / Math.Log(numero);
            var y = 1.25506 * numero / Math.Log(numero);
            Console.WriteLine($"{x:f1} {y:f1}");
        }
    }
}
