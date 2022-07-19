﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Person
    {
        
            public string name { get; set; }
            public int id { get; set; }
            public int age { get; set; }
            public string address { get; set; }
            public string email { get; set; }

            public Person(int id, string name, int age, string email, string address)
            {
                this.id = id;
                this.name = name;
                this.age = age;
                this.email = email;
                this.address = address;
            }
            

            public Person()
            {
            }

            public void CheckAge(int age)
            {
                if (age >= 18)
                    Console.WriteLine("Bạn đủ tuổi bầu cử");
                Console.WriteLine("Bạn còn nhỏ");
            }

            public void Input()
            {
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Age: ");
                age = int.Parse(Console.ReadLine());

                Console.Write("Email: ");
                email = Console.ReadLine();

                Console.Write("Address: ");
                address = Console.ReadLine();
            }
            public void Output()
            {
                Console.Write("Id: " + id + "\n");
                Console.Write("Name: " + name + "\n");
                Console.Write("Age: " + age + "\n");
                Console.Write("Email: " + email + "\n");
                Console.Write("Address: " + address + "\n");
            }

        
    }
}
