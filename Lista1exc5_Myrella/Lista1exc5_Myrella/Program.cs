using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1exc5_Myrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;
            int M;

            Console.WriteLine("Insira o primeiro valor:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro valor");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o Quarto valor");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("A média aritimética dos valores apresentados é");
            M = (a + b + c + d)/4;

            Console.WriteLine(M);
        }
    }
}
