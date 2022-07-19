using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao canh a: ");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao canh a: ");
            Double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao canh a: ");
            Double c = Convert.ToDouble(Console.ReadLine());

            if(a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0)
            {
                Double p = a + b + c; 
                Console.WriteLine("Chu vi tam giac la: " + p);
                Double p2 = p / 2;
                Double s = Math.Sqrt(p2 * (p2 - a) * (p2 - b) * (p2 - c));
                Console.WriteLine("Dien tich tam giac la: " + s);
            }
            else
            {
                Console.WriteLine("Vui long nhap lai...");
            }
        }
    }
}
