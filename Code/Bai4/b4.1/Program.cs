using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Person person = new Person();
            Console.WriteLine("Nhập vào Person: ");
            person.Input();
            Console.WriteLine("Person vừa nhập: ");
            person.Output();
        }
    }
}
