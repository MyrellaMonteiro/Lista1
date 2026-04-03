using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1exc3_Myrella_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d;
            int a;

            Console.WriteLine("Informe a diagonal do quadrado:");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("A area do quadrado é");
            a = (d * d) / 2;

            Console.Write(a);
        }
    }
}
