using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.1415926, a, r, V, Sa;
            string altura, raio;
            Console.WriteLine("Insira a altura:");
            altura = Console.ReadLine();
            Console.WriteLine("Insira o raio:");
            raio= Console.ReadLine();
            a = double.Parse(altura);
            r = double.Parse(raio);
            V = Math.PI * Math.Pow(r, 2) * a; 
            Sa = 2 * pi * r * (r + a); 
            Console.WriteLine("Volume do cilindro: " + V);
            Console.WriteLine("Area superficial: " + Sa);
        }
    }
}
