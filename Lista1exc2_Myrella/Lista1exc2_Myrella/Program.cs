using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1exc2_Myrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int h;
            int a;

            Console.WriteLine("Informe a base do reângulo:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("informe a altura do retângulo:");
            h = int.Parse(Console.ReadLine());

            Console.WriteLine("A area do retângulo é ");
            a = h * b;

            Console.WriteLine(a);
        }
    }
}
