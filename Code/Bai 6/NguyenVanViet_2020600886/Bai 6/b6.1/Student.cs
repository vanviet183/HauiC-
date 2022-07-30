﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b6._1
{
    internal class Student : Person
    {
        public byte math { get; set; }
        public byte physics { get; set; }

        public Student()
        {

        }

        public Student(int id, string name, string address, byte math, byte physics) : base(address, name)
        {
            this.name = name;
            this.address = address;
            this.math = math;
            this.physics = physics;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Enter the math: ");
            math = byte.Parse(Console.ReadLine());

            Console.Write("Enter the physics: ");
            physics = byte.Parse(Console.ReadLine());

        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"{math,10}" + $"{physics,10}" + $"{Total(),10}");

        }

        public byte Total()
        {
            return (byte)(math + physics);
        }
    }
}