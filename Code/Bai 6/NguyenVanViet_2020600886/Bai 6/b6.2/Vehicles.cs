using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b6._2
{
    class Vehicles : IVehicle
    {
        public string id { get; set; }
        public string maker { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public double price { get; set; }

        public Vehicles()
        {

        }

        public Vehicles(double price)
        {
            this.price = price;
        }

        public Vehicles(string id, string maker, string model, int year, double price)
        {
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public virtual void Input()
        {
            Console.Write("Nhap id: ");
            id = Console.ReadLine();

            Console.Write("Nhap maker: ");
            maker = Console.ReadLine();

            Console.Write("Nhap model: ");
            model = Console.ReadLine();

            Console.Write("Nhap year: ");
            year = int.Parse(Console.ReadLine());

            Console.Write("Nhap price: ");
            price = double.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.Write($"{id,15}" + $"{maker,15}" + $"{model,15}" + $"{year,15}" + $"{price,15}");
        }

        public override bool Equals(object obj)
        {
            Vehicles vehicles = obj as Vehicles;
            return (this.id.Equals(vehicles.id));
        }

        public override string ToString()
        {
            string str = String.Format("{0, -8}{1, -15}{2, -25}{3, -10}{4, -10}",
                            id, maker, model, year, price);
            return str;
        }


    }
}
