using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("A / B = {0}", a / b);
            Console.ReadKey();
        }
    }
}
