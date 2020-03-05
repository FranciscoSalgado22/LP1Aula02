using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 3, c;
            c = a++ * b++;
            Console.WriteLine("Resultado é:" + c);
        }
    }
}
