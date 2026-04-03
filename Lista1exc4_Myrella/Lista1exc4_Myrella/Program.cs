using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1exc4_Myrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int h;
            int a;

            Console.WriteLine("Informe a base do triângulo:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do triângulo:");
            h = int.Parse(Console.ReadLine());

            Console.WriteLine("A area do triângulo é ");
            a = (b * h) / 2;
            Console.WriteLine(a);
        }
    }
}
