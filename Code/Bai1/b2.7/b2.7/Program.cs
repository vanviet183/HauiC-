using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Nhap vao a: ");
            a = Convert.ToInt16(Console.ReadLine());

            Console.Write("Nhap vao b: ");
            b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine(a + " + " + b + " = " + (a + b));

        }
    }
}
