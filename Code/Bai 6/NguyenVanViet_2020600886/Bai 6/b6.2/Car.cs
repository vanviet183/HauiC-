using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b6._2
{
    class Car : Vehicles
    {
        private Vehicles vehicle;

        public string color { get; set; }

        public Car()
        {

        }

        public Car(string id, string maker, string model, int year, double price, string color) : base(id, maker, model, year, price)
        {
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
            this.color = color;
        }

        public Car(Vehicles vehicle, string color)
        {
            this.vehicle = vehicle;
            this.color = color;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap mau: ");
            color = Console.ReadLine();

        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"{color,15}");
        }
    }
}
