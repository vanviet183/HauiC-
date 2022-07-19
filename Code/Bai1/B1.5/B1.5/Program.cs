using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1._5
{
    internal class Program
    {
        static int sumA(int n)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++)
                sum += i;
            return sum;
        }

        static Double sumB(int n)
        {
            if (n == 1)
                return 1;
            else 
                return sumB(n - 1) + (1.0 / n);
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong a = " + sumA(n));
            Console.WriteLine("Tong b = " + sumB(n));
        }
    }

}
