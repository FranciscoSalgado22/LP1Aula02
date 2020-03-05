using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 3, c;
            c = a++ * b++;
            Console.WriteLine("Resultado de incremento em sufixo: " + c);
            int d = 10, e = 5, f;
            f = ++d - ++e;
            Console.WriteLine("Resultado de incremento em prefixo: " + f);
        }
    }
}
