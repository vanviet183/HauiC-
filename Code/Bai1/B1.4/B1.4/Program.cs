using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ho ten hoc sinh: ");
            String fullName = Console.ReadLine();
            Console.Write("Nhap diem thi: ");
            Double mark = Convert.ToDouble(Console.ReadLine());
            if(mark >= 8)
                Console.WriteLine("Xep loai GIOI");
            else if(mark >= 6.5 && mark < 8)
                Console.WriteLine("Xep loai KHA");
            else if (mark >= 5 && mark < 6.5)
                Console.WriteLine("Xep loai TB");
            else 
                Console.WriteLine("Xep loai YEU");

        }
    }
}
