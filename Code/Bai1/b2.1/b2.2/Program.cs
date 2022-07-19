using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2._2
{
    internal class Program
    {

        /* Thêm vào Solution đã tạo ở Bài tập 1 project mới có tên là Fibonacci. Thiết lập nó 
            là project mặc định.
            Viết chương trình cho phép nhập vào một số nguyên dương n và in ra n số 
            Fibonacci đầu tiên.
            Quy luật của dãy số Fibonacci: số tiếp theo bằng tổng của 2 số trước, 2 số đầu tiên 
            của dãy số là 0, 1. Ví dụ: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...
         * 
         */

        static int fibonacci(int n)
        {
            if (n == 0)
                return 0;
            if(n == 1)
                return 1;
            return fibonacci(n - 1) + fibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            int f0 = 0, f1 = 1;
            int fn = f0 + f1;
            Console.Write("Nhap n: ");
            int n = Convert.ToInt16(Console.ReadLine());
            // Cach 1
            /*
            Console.Write(f0 + " " + f1 + " ");
            for (int i = 2; i <= n; i++)
            {
                fn = f0 + f1;
                f0 = f1;
                f1 = fn;
                Console.Write(fn + " ");
            }
            */

            // Cach 2
            for (int i = 0; i <= n; i++)
            {
                Console.Write(fibonacci(i) + " ");
            }
        }
    }
}
