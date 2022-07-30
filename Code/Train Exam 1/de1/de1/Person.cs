using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de1
{
    internal class Person
    {
        private string name;

        private string address;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public virtual void Input()
        {
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();

            Console.Write("Nhap dia chi: ");
            address = Console.ReadLine();
        }
    }
}
