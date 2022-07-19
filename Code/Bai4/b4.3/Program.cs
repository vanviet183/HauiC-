using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Student student = new Student();
            Console.WriteLine("Nhập vào Student: ");
            student.Input();

            Console.WriteLine("Thông tin Student vừa nhập: ");
            student.Output();

        }
    }
}
