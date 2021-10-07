using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurzija
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Zaporedje1(2));
            Console.WriteLine(Zaporedje1(5));
            Console.WriteLine(Zaporedje2(2));
            Console.WriteLine(Zaporedje2(5));
            Console.ReadLine();
        }
        static int Zaporedje1(int n)
        {
            if (n <= 2)
                return 2;
            return Zaporedje1(n - 2) * Zaporedje1(n - 1) - 1;
        }
        static int Zaporedje2(int n)
        {
            if (n < 2)
                return 2;
            return 3 * Zaporedje2(n - 1) + 2;
        }
        static int Zaporedje3(int n)
        {
            if(n==1)
                return 1;
            if(n==2)
                return 2;
            return Zaporedje3(n - 1) * 2 + Zaporedje3(n - 2);

        }
    }
}
