using System;
using System.Text;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            short nsmax = short.MaxValue, nsmin = short.MinValue;
            ushort nusmax = ushort.MaxValue, nusmin = ushort.MinValue;
            int nmax = Int32.MaxValue, nmin = Int32.MinValue;
            uint unmax = uint.MaxValue, unmin = uint.MinValue;
            long nlmax = long.MaxValue, nlmin = long.MinValue;
            ulong unlmax = ulong.MaxValue, unlmin = ulong.MinValue;
            double dmax = double.MaxValue, dmin = double.MinValue;
            float fmax = float.MaxValue,  fmin = float.MinValue;
            byte bmax = byte.MaxValue, bmin = byte.MinValue;
            Console.WriteLine("short min val: " + nsmin + " short max val: " + nsmax);
            Console.WriteLine("ushort min val: " + nusmin + " ushort max val: " + nusmax);
            Console.WriteLine("int min val: " + nmin + " int max val: " + nmax);
            Console.WriteLine("uint min val: " + unmin + " uint max val: " + unmax);
            Console.WriteLine("long min val: " + nlmin + " long max val: " + nlmax);
            Console.WriteLine("ulong min val: " + unlmin + " ulong max val: " + unlmax);
            Console.WriteLine("double min val: " + dmin + " double max val: " + dmax);
            Console.WriteLine("float min val: " + fmin + " float max val: " + fmax);
            Console.WriteLine("infinito float: " + float.PositiveInfinity + " infinito negativo float: " + float.NegativeInfinity);
            Console.WriteLine("infinito double: " + double.PositiveInfinity + " infinito negativo double: " + double.NegativeInfinity);
            Console.WriteLine("byte min val: " + bmin + " byte max val: " + bmax);

            int i = int.MaxValue; 
            Console.WriteLine(( i + 1));

        }
    }
}
