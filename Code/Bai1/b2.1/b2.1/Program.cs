using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double a, b;
            Console.Write("Nhap chieu dai: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Chu vi HCN: " + 2 * (a + b));
            Console.WriteLine("Dien tich HCN: " + a * b);
        }
    }
}
