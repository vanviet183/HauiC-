using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Circle circle = new Circle();
            Console.Write("Nhap ban kinh hinh tron: ");
            circle.radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Diện tích hình tròn là: " + circle.Area(circle.radius));
            Console.WriteLine("Chu vi hình tròn là: " + circle.Perimeter(circle.radius));
        }
    }
}
