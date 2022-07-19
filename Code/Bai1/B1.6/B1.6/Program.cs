using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1._6
{
    internal class Program
    {
        static Double sqrtCustom(Double a)
        {
            if (a == 0)
                return 1;
            else
                return (a / sqrtCustom(a - 1) + sqrtCustom(a - 1)) / 2;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap a: ");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap epsilon: ");
            Double e = Convert.ToDouble(Console.ReadLine());
            Double result = 1;
            
            while (Math.Abs(result * result - a) / a >= e)
                result = (a / (result) + result) / 2;

            Console.WriteLine(Math.Sqrt(a));
            Console.WriteLine(result);
            Console.WriteLine(sqrtCustom(a));
        }
    }
}
