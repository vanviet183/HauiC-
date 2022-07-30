using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b6._2
{
    class Truck : Vehicles
    {
        private Vehicles vehicles;

        public int truckload { get; set; }

        public Truck()
        {

        }

        public Truck(string id, string maker, string model, int year, double price, int truckload) : base(id, maker, model, year, price)
        {
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
            this.truckload = truckload;
        }

        public Truck(Vehicles vehicles, int truckload)
        {
            this.vehicles = vehicles;
            this.truckload = truckload;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap trong tai: ");
            truckload = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"{"",15}" + $"{truckload,15}");

        }
    }
}
