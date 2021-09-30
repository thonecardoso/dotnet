using System;

namespace _3303_Palavrao
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var p = Console.ReadLine();
                if (string.IsNullOrEmpty(p))
                    break;
                Console.WriteLine(p.Length > 9 ? "palavrao" : "palavrinha");
            }
        }
    }
}
