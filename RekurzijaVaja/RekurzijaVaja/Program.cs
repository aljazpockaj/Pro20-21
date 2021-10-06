using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekurzijaVaja
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(PotencaIterativno(10));
            //Console.ReadLine();
            //Console.WriteLine(PotencaRekurzivno(10));
            //Console.ReadLine();
            Console.WriteLine("Sedmo fib. stevilo je: " + Fib(250));
            Console.ReadLine();
        }
        static int PotencaIterativno(int n)
        {
            int potenca = 1;
            for(int k=1; k<= n;k++)
            {
                potenca = potenca * 2;
            }
            return potenca;
        }
        static int PotencaRekurzivno(int n)
        {
            if (n == 0)
                return 1;
            return 2 * PotencaRekurzivno(n - 1);

        }
        static int Fib(int n)
        {
            //Rekurizvno izračuna fib.število
            if (n == 1 || n == 2)
                return 1;
            return Fib(n - 1) + Fib(n - 2);

        }
    }
}
