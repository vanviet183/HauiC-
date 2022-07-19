using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int giaiThua(int n)
        {
            if (n == 0)
                return 1;
            return giaiThua(n - 1) * n;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Giai thua cua " + n + " = " + giaiThua(n));
        }
    }
}
