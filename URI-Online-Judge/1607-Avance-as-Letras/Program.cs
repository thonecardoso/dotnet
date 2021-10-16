using System;
using System.Linq;

namespace _1607_Avance_as_Letras
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            while (n-- > 0)
            {
                var v = Console.ReadLine().Split();
                var a = v[0];
                var b = v[1];
                Console.WriteLine(a.Select((e,i)=>
                        e<= b[i] 
                        ?
                            Math.Abs(e - b[i])
                        : 
                            'z' - e  + b[i] - 'a' + 1
                    ).Sum());
            }
        }
    }
}
