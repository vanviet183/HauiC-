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
        

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public Person()
        {
        }

        public Person(int id) 
        {
            this.id = id;
        }

        public virtual void Input()
        {
            Console.Write("Nhap id: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Enter the name: ");
            name = Console.ReadLine();

            Console.Write("Enter the address: ");
            address = Console.ReadLine();
        }

        public virtual void Output()
        {
            Console.Write($"{id,10}" + $"{name,10}" + $"{address,10}");

        }
    }
}
