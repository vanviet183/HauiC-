using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b6._1
{
    internal class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        private static int cnt = 1;

        public Person(string name, string address)
        {
            this.id = cnt++;
            this.name = name;
            this.address = address;
        }

        public Person()
        {
            this.id = cnt++;

        }

        public void Input()
        {
            Console.Write("Enter the name: ");
            name = Console.ReadLine();

            Console.Write("Enter the address: ");
            address = Console.ReadLine();
        }

        public void Output()
        {
            Console.Write($"{id, 10}" + $"{name, 10}" + $"{address, 10}");

        }
    }
}
