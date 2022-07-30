using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b6._3
{
    internal class Student
    {
        public int studentId { get; set; }
        public string name { get; set; }
        public double mark { get; set; }

        public void ToString()
        {
            Console.WriteLine("id: " + studentId + ", name: " + name + ", mark: " + mark);
        }

        public void InputStudent()
        {
            Console.Write("Input id student: ");
            studentId = int.Parse(Console.ReadLine());

            Console.Write("Input name student: ");
            name = Console.ReadLine();

            Console.Write("Input mark student: ");
            mark = double.Parse(Console.ReadLine());

        }
    }
}
