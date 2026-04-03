using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1exc1_Myrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l;
            int a;

            Console.WriteLine("Informe a aresta do quadrado");
            l = int.Parse(Console.ReadLine());

            Console.WriteLine("A area do quadrado é ");
            a = l * l;
            Console.WriteLine(a);
        }
    }
}
