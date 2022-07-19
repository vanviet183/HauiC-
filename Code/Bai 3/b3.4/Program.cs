using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b3._4
{
    internal class Program
    {
        static void bangCuuChuong(int n)
        {
            for(int i = 1; i <= 10; i++)
                Console.WriteLine(n + " x " + i + " = " + (n * i));
        }

        static void Main(string[] args)
        {
            for(int i = 1; i <= 9; i++)
            {
                Console.WriteLine("Bang Cuu Chuong " + i);
                bangCuuChuong(i);

            }
        }
    }
}
