using System;

namespace Diagram
{
    class Program
    {
        static void Main(string[] args)
        {
            liczby L1 = new liczby(5, 9, 1);
            liczby L2 = new liczby(6, 2, 8);

            L1.A = 3;
            L1.B = 1;
            L1.C = 2;

            L2.A = 23;
            L2.B = 11;
            L2.C = 2;

            lepsze_liczby LL1 = new lepsze_liczby(1, 2, 3, 4);

            LL1.A = 21;
            LL1.B = 16;
            LL1.C = 11;
            LL1.D = 1;

            Console.WriteLine("Liczby nr 1:");
            Console.WriteLine(L1.A + " " + L1.B + " " + L1.C);
            Console.WriteLine("Liczby nr 2:");
            Console.WriteLine(L2.A + " " + L2.B + " " + L2.C);
            Console.WriteLine("Lepsza Liczba nr 1:");
            Console.WriteLine(LL1.A + " " + LL1.B + " " + LL1.C + " " + LL1.D);
            Console.ReadKey();

        }
    }
}
