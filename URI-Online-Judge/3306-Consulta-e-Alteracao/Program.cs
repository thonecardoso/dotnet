using System;
using System.Linq;

namespace _3306_Consulta_e_Alteracao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            while (true)
            {
                var entrada = Console.ReadLine();
                if (string.IsNullOrEmpty(entrada))
                    break;
                var v_in = entrada.Split().Select(valor => int.Parse(valor)).ToList();

                var input = Console.ReadLine().Split();
                var v = input.Select(valor => int.Parse(valor)).ToList();

                for (var y = 0; y < v_in[1]; y++)
                {
                    var read = Console.ReadLine();
                    if (string.IsNullOrEmpty(read))
                    {
                        Console.WriteLine(y+1);
                        continue;
                    }
                        

                    var q = read.Split().Select(valor => int.Parse(valor)).ToList();
                    
                    if (q[0] == 2)
                    {
                        var mdc = MDC(v[q[1] - 1], v[q[1]]);
                        for (var i = q[1]; i < q[2] - 1; i++)
                        {
                            mdc = MDC(mdc, v[i + 1]);
                        }
                        Console.WriteLine(mdc);
                    }
                    else
                    {
                        for (var i = q[1] - 1; i < q[2]; i++)
                        {
                            v[i] += q[3];
                        }

                    }
                }

            }
        }

        static int MDC(int a, int b)
        {
            if (a < b)
            {
                var aux = a;
                a = b;
                b = aux;
            }

            if (a % b == 0) return b;
            else return MDC(b, a%b);
        }
    }
}
